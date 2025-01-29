#include "Utilities.h"
#include <iostream>
#include <limits>
#include <string>

using namespace std;

void Utilities::PressEnterToContinue() {
    std::cout << "Press Enter to continue..." << std::endl;

    // Wait for the user to press Enter
    std::cin.get();
}

void Utilities::Welcome() {
    std::cout << "-----Welcome to MyC++QuizApp-----" << std::endl;
}

void Utilities::Menu() {
    std::cout << "1. Start Quiz         :" << std::endl;
    std::cout << "2. Scoreboard         :" << std::endl;
    std::cout << "3. Exit               :" << std::endl;
}




string Utilities::GetUserInput(const string& prompt) {
    cout << prompt; // Display the prompt
    string input;

    // Clear any leftover newline character from previous input
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    // Read the user input
    getline(cin, input);

    return input; // Return the input
}

int Utilities::GetNumericInput(const string& prompt) {
    cout << prompt; // Display the prompt
    int input;

    // Validate numeric input
    while (!(std::cin >> input)) {
        std::cin.clear(); // Clear the error flag
        std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n'); // Discard invalid input
        std::cout << "Invalid input. Please enter a number: ";
    }


    return input; // Return the input
}
