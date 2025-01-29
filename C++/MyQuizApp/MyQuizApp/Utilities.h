#pragma once
#include <iostream>
using namespace std;

class Utilities
{
public:
	void Welcome();
	void Menu();
	void PressEnterToContinue();
	string GetUserInput(const string& prompt);
	int GetNumericInput(const string& prompt);
};