#include <iostream>
#include <fstream>
#include <string>
using namespace std;

void CreateFile(string fileName)
{
	ofstream a_file(fileName);

	cout << fileName <<  " creation success\n";
}

//find the file upon initialization
void WelcomeMessage()
{
	string line;
	//Read from a text file the welcome message
	ifstream welcomeMessage;
	welcomeMessage.open("welcome.txt");

	//check that the message is already open
	if (welcomeMessage.is_open())
	{
		while (getline(welcomeMessage, line))
		{
			cout << line << '\n';
		}
		welcomeMessage.close();
	}
	else
	{
		cout << "Unable to open file \n";
	}
}

//find the target files
void TrainDirectoryFile()
{
	string targetTrainFile;
	string line;
	int numChoice;				//the choice number

	cout << "Define target training directory file (DO NOT ATTACH .txt INSIDE): ";
	cin >> targetTrainFile;
	targetTrainFile = targetTrainFile + ".txt";

	while (true)
	{
		cout << "1. Create new entries" << endl;
		cout << "2. See current entries in file" << endl;
		cout << "3. Exit to main menu" << endl;

		//error checking
		while (!(cin >> numChoice))
		{
			cin.clear();
			cin.ignore(999, '\n');
			cout << "Invalid input. Please enter again: ";
		}

		//write into file
		if (numChoice == 1)
		{
			ofstream writeLabelFile;
			writeLabelFile.open(targetTrainFile, ios::app);
			//define the number of labels to be added
			int numDirectoryLabels;
			string directoryName, fileName;
			cout << "Define the number of directory labels to add: \n";

			//error check number of labels
			while (!(cin >> numDirectoryLabels))
			{
				cin.clear();
				cin.ignore(999, '\n');
				cout << "Invalid input. Please enter again: \n";
			}

			cout << "Define the directory label (eg. /home/ntcadmin/mnist/train/) \n";
			cin >> directoryName;

			cout << "Define the picture name(s). Ensure that the picture names are the same and separated by number (eg. fail(1) and fail(2)) \n";
			cin >> fileName;

			//loop through the entries
			for (int i = 1; i < numDirectoryLabels + 1; i++)
			{
				//write into the text file
				writeLabelFile << directoryName << fileName << "(" << i << ")" << '\n';
			}
			cout << "Operation complete \n";
			writeLabelFile.close();
		}
		else if (numChoice == 2)
		{
			ifstream openLabelFile;
			openLabelFile.open(targetTrainFile);

			//if it does, then execute this
			if (openLabelFile.is_open())
			{
				cout << "Here are the entries starting from the top" << endl;

				while (getline(openLabelFile, line))
				{
					cout << line << '\n';
				}
				openLabelFile.close();
			}
		}
		else if (numChoice == 3)
		{
			break;
		}
		else
		{
			cout << "Invalid input. Please enter again: \n";
		}
	}
}

//create label data
void LabelData()
{
	string targetLabelFile;
	string line;
	int numChoice;				//the choice number

	cout << "Define target label file (DO NOT ATTACH .txt INSIDE): ";
	cin >> targetLabelFile;
	targetLabelFile = targetLabelFile + ".txt";

	while (true)
	{
		cout << "1. Create new entries" << endl;
		cout << "2. See current entries in file" << endl;
		cout << "3. Exit to main menu" << endl;

		//error checking
		while (!(cin >> numChoice))
		{
			cin.clear();
			cin.ignore(999, '\n');
			cout << "Invalid input. Please enter again: ";
		}

		//write into file
		if (numChoice == 1)
		{
			ofstream writeLabelFile;
			writeLabelFile.open(targetLabelFile);
			//define the number of labels to be added
			int numLabels;
			string labelName;
			cout << "Define the number of labels to add: ";

			//error check number of labels
			while (!(cin >> numLabels))
			{
				cin.clear();
				cin.ignore(999, '\n');
				cout << "Invalid input. Please enter again: ";
			}

			//loop through the entries
			for (int i = 1; i < numLabels + 1; i++)
			{
				cout << i << " ";
				cin >> labelName;
				//write into the text file
				writeLabelFile << labelName << '\n';
				cin.clear();
			}
			writeLabelFile.close();
		}
		else if (numChoice == 2)
		{
			ifstream openLabelFile;
			openLabelFile.open(targetLabelFile);

			//if it does, then execute this
			if (openLabelFile.is_open())
			{
				cout << "Here are the entries starting from the top" << endl;

				while (getline(openLabelFile, line))
				{
					cout << line << '\n';
				}
				openLabelFile.close();
			}
		}
		else if (numChoice == 3)
		{
			break;
		}
		else
		{
			cout << "Invalid input. Please enter again: ";
		}
	}
}
void main()
{
	int numberChosen;
	while (true)
	{
		WelcomeMessage();		//show welcome message

		//error check on number chosen
		while (!(cin >> numberChosen))
		{
			cin.clear();
			cin.ignore(999, '\n');
			cout << "Invalid input. Please enter again: ";
		}
		if (numberChosen == 1)
		{
			LabelData();
		}
		else if (numberChosen == 2)
		{
			TrainDirectoryFile();
		}
		else if (numberChosen == 3)
		{
			break;
		}
		else
		{
			cout << "Invalid input. Please enter again: ";
		}
	}
}