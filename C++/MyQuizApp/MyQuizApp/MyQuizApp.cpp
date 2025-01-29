#include <iostream>
#include <Windows.h>
#include <sqlext.h>
#include <sqltypes.h>
#include <sql.h>

#include "Utilities.h"

using namespace std;

void showSQLError(unsigned int handleType, const SQLHANDLE& handle) {
    SQLWCHAR SQLState[1024];
    SQLWCHAR messageText[1024];
    if (SQL_SUCCESS == SQLGetDiagRec(handleType, handle, 1, SQLState, NULL, messageText, 1024, NULL)) {
        // Outputs some info
        wcout << "SQLSTATE: " << SQLState << endl;
        wcout << "Message: " << messageText << endl;
    }
}

int main() {

	Utilities utility;

	utility.Welcome();

	utility.PressEnterToContinue();

    while (true) {

		utility.Menu();
		int option = utility.GetNumericInput("Choose option: ");
		switch (option) {
		case 1:
			// Start Quiz
			break;
		case 2:
			// Scoreboard
			break;
		case 3:
			// Exit
			return 0;
		default:
			cout << "Invalid option. Please try again." << endl;
		}



	int option = utility.GetNumericInput("Choose option: ");


    SQLHANDLE SQLENvHandle = NULL;
    SQLHANDLE SQLConnectionHandle = NULL;
    SQLHANDLE SQLStatementHandle = NULL;
    SQLRETURN retCode = 0;
    SQLWCHAR SQLQuery[] = L"SELECT * FROM Score"; // Wide-character query

    do {
        // Allocate environment handle
        if (SQL_SUCCESS != SQLAllocHandle(SQL_HANDLE_ENV, SQL_NULL_HANDLE, &SQLENvHandle)) {
            std::wcerr << L"Unable to allocate environment handle.\n";
            break;
        }

        // Set environment attributes
        if (SQL_SUCCESS != SQLSetEnvAttr(SQLENvHandle, SQL_ATTR_ODBC_VERSION, (SQLPOINTER)SQL_OV_ODBC3, 0)) {
            std::wcerr << L"Unable to set environment attributes.\n";
            break;
        }

        // Allocate connection handle
        if (SQL_SUCCESS != SQLAllocHandle(SQL_HANDLE_DBC, SQLENvHandle, &SQLConnectionHandle)) {
            std::wcerr << L"Unable to allocate connection handle.\n";
            break;
        }

        // Set connection attributes
        if (SQL_SUCCESS != SQLSetConnectAttr(SQLConnectionHandle, SQL_LOGIN_TIMEOUT, (SQLPOINTER)5, 0)) {
            std::wcerr << L"Unable to set connection attributes.\n";
            break;
        }

        // Wide-character connection string
        SQLWCHAR connectionString[] =
            L"DRIVER={ODBC Driver 17 for SQL Server}; SERVER=DESKTOP-G83IEC9; DATABASE=Scoreboard1; Trusted_Connection=yes;";
        SQLWCHAR retConString[1024];

        switch (SQLDriverConnectW(SQLConnectionHandle, NULL, connectionString, SQL_NTS, retConString, 1024, NULL, SQL_DRIVER_NOPROMPT)) {
        case SQL_SUCCESS:
        case SQL_SUCCESS_WITH_INFO:
            std::wcout << L"Successfully connected to the database.\n";
            break;
        case SQL_NO_DATA_FOUND:
        case SQL_INVALID_HANDLE:
        case SQL_ERROR:
            showSQLError(SQL_HANDLE_DBC, SQLConnectionHandle);
            retCode = -1;
            break;
        default:
            std::wcerr << L"Unexpected error occurred during connection.\n";
            retCode = -1;
        }

        if (retCode == -1) break;

        // Allocate statement handle
        if (SQL_SUCCESS != SQLAllocHandle(SQL_HANDLE_STMT, SQLConnectionHandle, &SQLStatementHandle)) {
            std::wcerr << L"Unable to allocate statement handle.\n";
            break;
        }

        // Execute the SQL query
        if (SQL_SUCCESS != SQLExecDirectW(SQLStatementHandle, SQLQuery, SQL_NTS)) {
            showSQLError(SQL_HANDLE_STMT, SQLStatementHandle);
            break;
        }

        // Fetch and display results
        SQLWCHAR Name[256];
        int Points;
        while (SQLFetch(SQLStatementHandle) == SQL_SUCCESS) {
            SQLGetData(SQLStatementHandle, 1, SQL_C_WCHAR, Name, sizeof(Name), NULL);
            SQLGetData(SQLStatementHandle, 2, SQL_C_SLONG, &Points, 0, NULL);
            std::wcout << L"Name: " << Name << L", Points: " << Points << std::endl;
        }

    } while (false);

    // Free resources
    if (SQLStatementHandle) SQLFreeHandle(SQL_HANDLE_STMT, SQLStatementHandle);
    if (SQLConnectionHandle) {
        SQLDisconnect(SQLConnectionHandle);
        SQLFreeHandle(SQL_HANDLE_DBC, SQLConnectionHandle);
    }
    if (SQLENvHandle) SQLFreeHandle(SQL_HANDLE_ENV, SQLENvHandle);

    }

