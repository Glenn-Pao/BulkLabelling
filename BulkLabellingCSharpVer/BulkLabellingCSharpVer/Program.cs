using System;
using System.IO;

namespace TestProj
{
	class MainClass
	{
		public static void WelcomeMessage()
		{
			string FileName = "welcome.txt";

			//READ FROM TEXT FILE//

			//Open the file into a stream reader
			StreamReader file = File.OpenText(FileName);

			//Read the file into a string
			string s = file.ReadToEnd();

			//close the file
			file.Close();

			Console.WriteLine (s);
		}

		public static string FindFile()
		{
			string targetLabelFile;
			char YesOrNo;

			//to cater to the scenario that the user ends up saying 'no', this has to be a loop
			while (true)
			{

				Console.WriteLine ("=========================================");
				Console.WriteLine ("Define target label file name. DO NOT ADD .txt INSIDE");
				Console.WriteLine ("=========================================");
				targetLabelFile = Console.ReadLine () + ".txt";


				//echo the label file name
				Console.WriteLine ("=========================================");
				Console.WriteLine (targetLabelFile + " is this correct? [Y/N]");
				Console.WriteLine ("=========================================");

				//parse the input into a character
				Char.TryParse (Console.ReadLine (), out YesOrNo);

				//Convert to uppercase only to reduce hard coding issues
				YesOrNo = Char.ToUpper (YesOrNo);

				//enter into a loop that throws an error if invalid input
				while (true) 
				{
					//break out of this loop once input is correct
					if (YesOrNo == 'Y' || YesOrNo == 'N') 
					{
						break;
					}

					//this is when there is an error to the input
					//ask the user again
					string error;
					error = "Error: Invalid input. \n";

					Console.WriteLine ("=========================================");
					Console.WriteLine (error);
					Console.WriteLine ("=========================================");

					//echo the label file name
					Console.WriteLine ("=========================================");
					Console.WriteLine (targetLabelFile + " is this correct? [Y/N]");
					Console.WriteLine ("=========================================");

					Char.TryParse (Console.ReadLine (), out YesOrNo);

					//Convert to uppercase only
					YesOrNo = Char.ToUpper (YesOrNo);
				}

				//based on the user feedback, the program will either find the file and return the file name
				//or it will ask the user again
				if (YesOrNo == 'Y') 
				{
					//check whether this text file exists
					//if it doesn't exist, create the file
					if (!File.Exists (targetLabelFile)) 
					{
						using (FileStream fs = File.Create (targetLabelFile)) 
						{
							Console.WriteLine ("=========================================");
							Console.WriteLine (targetLabelFile + " missing!");
							Console.WriteLine (targetLabelFile + " created! Please check your folder.");
							Console.WriteLine ("=========================================");
						}
					} 
					else 
					{
						Console.WriteLine ("=========================================");
						Console.WriteLine (targetLabelFile + " found!");
					}
					//this automatically breaks out of the loop so there is no need to do a break command here
					return targetLabelFile;
				}
			}
		}

		public static void WriteLabelData(string fileName)
		{
			//get the number of entries to add
			int entryNum;

			Console.WriteLine ("=========================================");
			Console.WriteLine (" Define the number of entries you want to add.");
			Console.WriteLine ("=========================================");


			//Choose a number, attempt to parse the phrase typed in by user into int
			if (!Int32.TryParse (Console.ReadLine (), out entryNum)) 
			{
				string error;
				error = "Error: Invalid input. Try again.";

				Console.WriteLine (error);
			}

			//write to text file
			//Hook a write to text file, allow for appending of data
			TextWriter writer = new StreamWriter(fileName, true);

			//run through a loop to record the label and write into text file
			for (int i = 1; i < entryNum + 1; i++) 
			{
				Console.WriteLine ("=========================================");
				//tag the line number
				Console.WriteLine ("Entry " + i);
				//write into text file
				writer.WriteLine (Console.ReadLine ());
			}
			//close the text file
			writer.Close ();
		}
		public static string DirectoryName()
		{
			char YesOrNoDirectoryName;
			string directoryName;			//the directory name

			while (true) 
			{
				Console.WriteLine ("=========================================");
				Console.WriteLine (" Define the directory name (eg. home/user/Desktop/...)");
				Console.WriteLine ("=========================================");

				directoryName = Console.ReadLine ();

				//echo the directory file name
				Console.WriteLine ("=========================================");
				Console.WriteLine (directoryName + " is this correct? [Y/N]");
				Console.WriteLine ("=========================================");

				//parse the input into a character
				Char.TryParse (Console.ReadLine (), out YesOrNoDirectoryName);

				//Convert to uppercase only to reduce hard coding issues
				YesOrNoDirectoryName = Char.ToUpper (YesOrNoDirectoryName);

				//enter into a loop that throws an error if invalid input
				while (true) 
				{
					//break out of this loop once input is correct
					if (YesOrNoDirectoryName == 'Y' || YesOrNoDirectoryName == 'N') 
					{
						break;
					}

					//this is when there is an error to the input
					//ask the user again
					string error;
					error = "Error: Invalid input. \n";

					Console.WriteLine ("=========================================");
					Console.WriteLine (error);
					Console.WriteLine ("=========================================");

					//echo the label file name
					Console.WriteLine ("=========================================");
					Console.WriteLine (directoryName + " is this correct? [Y/N]");
					Console.WriteLine ("=========================================");

					Char.TryParse (Console.ReadLine (), out YesOrNoDirectoryName);

					//Convert to uppercase only
					YesOrNoDirectoryName = Char.ToUpper (YesOrNoDirectoryName);
				}
				if (YesOrNoDirectoryName == 'Y') 
				{
					return directoryName;
				}
			}

		}
		public static string TrainingFileName()
		{
			string trainingFileName;		//the image name
			char YesOrNoFileName;			//file name check

			while (true) 
			{

				Console.WriteLine ("=========================================");
				Console.WriteLine (" Define the image name (eg. sample)");
				Console.WriteLine ("=========================================");

				trainingFileName = Console.ReadLine ();

				//echo the directory file name
				Console.WriteLine ("=========================================");
				Console.WriteLine (trainingFileName + " is this correct? [Y/N]");
				Console.WriteLine ("=========================================");

				//parse the input into a character
				Char.TryParse (Console.ReadLine (), out YesOrNoFileName);

				//Convert to uppercase only to reduce hard coding issues
				YesOrNoFileName = Char.ToUpper (YesOrNoFileName);

				//enter into a loop that throws an error if invalid input
				while (true) 
				{
					//break out of this loop once input is correct
					if (YesOrNoFileName == 'Y' || YesOrNoFileName == 'N') 
					{
						break;
					}

					//this is when there is an error to the input
					//ask the user again
					string error;
					error = "Error: Invalid input. \n";

					Console.WriteLine ("=========================================");
					Console.WriteLine (error);
					Console.WriteLine ("=========================================");

					//echo the label file name
					Console.WriteLine ("=========================================");
					Console.WriteLine (trainingFileName + " is this correct? [Y/N]");
					Console.WriteLine ("=========================================");

					Char.TryParse (Console.ReadLine (), out YesOrNoFileName);

					//Convert to uppercase only
					YesOrNoFileName = Char.ToUpper (YesOrNoFileName);
				}
				if (YesOrNoFileName == 'Y') 
				{
					return trainingFileName;
				}
			}

		}
		public static string LabelTag()
		{
			string labelName;		//the image name
			char YesOrNoLabelName;			//file name check

			while (true) 
			{

				Console.WriteLine ("=========================================");
				Console.WriteLine (" Define the label name (eg. sample)");
				Console.WriteLine ("=========================================");

				labelName = Console.ReadLine ();

				//echo the directory file name
				Console.WriteLine ("=========================================");
				Console.WriteLine (labelName + " is this correct? [Y/N]");
				Console.WriteLine ("=========================================");

				//parse the input into a character
				Char.TryParse (Console.ReadLine (), out YesOrNoLabelName);

				//Convert to uppercase only to reduce hard coding issues
				YesOrNoLabelName = Char.ToUpper (YesOrNoLabelName);

				//enter into a loop that throws an error if invalid input
				while (true) 
				{
					//break out of this loop once input is correct
					if (YesOrNoLabelName == 'Y' || YesOrNoLabelName == 'N') 
					{
						break;
					}

					//this is when there is an error to the input
					//ask the user again
					string error;
					error = "Error: Invalid input. \n";

					Console.WriteLine ("=========================================");
					Console.WriteLine (error);
					Console.WriteLine ("=========================================");

					//echo the label file name
					Console.WriteLine ("=========================================");
					Console.WriteLine (labelName + " is this correct? [Y/N]");
					Console.WriteLine ("=========================================");

					Char.TryParse (Console.ReadLine (), out YesOrNoLabelName);

					//Convert to uppercase only
					YesOrNoLabelName = Char.ToUpper (YesOrNoLabelName);
				}
				if (YesOrNoLabelName == 'Y') 
				{
					return labelName;
				}
			}
		}
		public static string FinalizeDirectoryName(int entryNum, string directoryName, string labelTag, string trainingFileName)
		{
			string finalFileName;			//directory + image + label names
			char YesOrNoFinalFileName;		//directory + image + label name check

			//combine both directory and training file names
			finalFileName = directoryName + trainingFileName + " " + labelTag;

			//echo the label file name
			Console.WriteLine ("=========================================");
			Console.WriteLine (finalFileName + " with " + entryNum + " entries. Is this correct? [Y/N]");
			Console.WriteLine ("=========================================");

			Char.TryParse (Console.ReadLine (), out YesOrNoFinalFileName);

			//Convert to uppercase only
			YesOrNoFinalFileName = Char.ToUpper (YesOrNoFinalFileName);

			//enter into a loop that throws an error if invalid input
			while (true) 
			{
				//break out of this loop once input is correct
				if (YesOrNoFinalFileName == 'Y' || YesOrNoFinalFileName == 'N') 
				{
					break;
				}

				//this is when there is an error to the input
				//ask the user again
				string error;
				error = "Error: Invalid input. \n";

				Console.WriteLine ("=========================================");
				Console.WriteLine (error);
				Console.WriteLine ("=========================================");

				//echo the label file name
				Console.WriteLine ("=========================================");
				Console.WriteLine (finalFileName + " is this correct? [Y/N]");
				Console.WriteLine ("=========================================");

				Char.TryParse (Console.ReadLine (), out YesOrNoFinalFileName);

				//Convert to uppercase only
				YesOrNoFinalFileName = Char.ToUpper (YesOrNoFinalFileName);
			}
			//if not, then repeat the process
			if (YesOrNoFinalFileName == 'Y') 
			{
				return finalFileName;
			} 
			else 
			{
				//repeat the directory and image name input
				return "0";
			}
		}

		public static void WriteDirectoryData (string fileName)
		{
			//get the number of entries to add
			int entryNum;
			string directoryName;			//the directory name
			string trainingFileName;		//the image name
			string labelTag;				//the label tag of this item
			string finalFileName = "0";		//directory + image names

			while (true) 
			{

				Console.WriteLine ("=========================================");
				Console.WriteLine (" Define the number of entries you want to add.");
				Console.WriteLine ("=========================================");


				//Choose a number, attempt to parse the phrase typed in by user into int
				if (!Int32.TryParse (Console.ReadLine (), out entryNum)) 
				{
					string error;
					error = "Error: Invalid input. Try again.";

					Console.WriteLine (error);
				} 
				else 
				{
					break;
				}
			}
	
			//just to make sure the final file name is filled in
			while (finalFileName == "0") 
			{
				directoryName = DirectoryName ();																		//get directory details
				trainingFileName = TrainingFileName ();																	//get file name details
				labelTag = LabelTag();																					//the label tag behind the directory
				finalFileName = FinalizeDirectoryName (entryNum, directoryName, labelTag, trainingFileName);			//get the finalized directory detail
			}




			//if it is a yes, then proceed with writing into text file
			//Once he confirms the directory name, get the file name
			TextWriter writer = new StreamWriter (fileName, true);

			//run through a loop to record the label and write into text file
			for (int i = 1; i < entryNum + 1; i++) 
			{
				//write the final directory and image names into the text file
				writer.WriteLine (finalFileName + "(" + i + ")");
			}
			//close the text file
			writer.Close ();
			return;
		}

		public static void ReadData(string fileName)
		{
			//READ FROM TEXT FILE//
			//Open the file into a stream reader
			StreamReader file = File.OpenText(fileName);

			//Read the file into a string
			string s = file.ReadToEnd();

			//close the file
			file.Close();
			Console.WriteLine ("=========================================");
			Console.WriteLine (s);
		}
		public static void LabelData()
		{
			int numChoice;
			string fileName;		//the file name of interest

			//find the text file for labelling
			fileName = FindFile ();

			//if it does exist, execute the operations needed.
			while (true) 
			{
				Console.WriteLine ("=========================================");
				Console.WriteLine ("1. Create new entries");
				Console.WriteLine ("2. See current entries in text file");
				Console.WriteLine ("3. Exit to main menu");
				Console.WriteLine ("=========================================");

				//Choose a number, attempt to parse the phrase typed in by user into int
				if (!Int32.TryParse (Console.ReadLine (), out numChoice)) 
				{
					string error;
					error = "Error: Invalid input. Try again.";

					Console.WriteLine (error);
				}

				//If number = 1, create new entries
				if (numChoice == 1) 
				{
					WriteLabelData (fileName);
				}
				//If num ber = 2, see the entries found in text file
				else if (numChoice == 2) 
				{
					ReadData (fileName);
				}
				//If number = 3, break this loop
				else if (numChoice == 3) 
				{
					break;
				}
			}
		}
		//pretty much the same as label data except that it stores a different set of data
		public static void DirectoryData()
		{
			int numChoice;
			string fileName;		//the file name of interest

			//find the text file for labelling
			fileName = FindFile ();

			//if it does exist, execute the operations needed.
			while (true) 
			{
				Console.WriteLine ("=========================================");
				Console.WriteLine ("1. Create new entries");
				Console.WriteLine ("2. See current entries in text file");
				Console.WriteLine ("3. Exit to main menu");
				Console.WriteLine ("=========================================");

				//Choose a number, attempt to parse the phrase typed in by user into int
				if (!Int32.TryParse (Console.ReadLine (), out numChoice)) 
				{
					string error;
					error = "Error: Invalid input. Try again.";

					Console.WriteLine (error);
				}

				//If number = 1, create new entries
				if (numChoice == 1) 
				{
					WriteDirectoryData (fileName);
				}
				//If number = 2, see the entries found in text file
				else if (numChoice == 2) 
				{
					ReadData (fileName);
				}
				//If number = 3, break this loop
				else if (numChoice == 3) 
				{
					break;
				}
			}
		}
		public static void Main (string[] args)
		{
			int numberChosen;

			while (true) 
			{
				//Show welcome message
				WelcomeMessage();

				//Choose a number, attempt to parse the phrase typed in by user into int
				if (!Int32.TryParse (Console.ReadLine (), out numberChosen)) 
				{
					string error;

					error = "Error: Invalid input. Try again.";

					Console.WriteLine ("=========================================");
					Console.WriteLine (error);
				}
				//If number = 1, execute Label Data function
				if (numberChosen == 1) 
				{
					LabelData ();
				}
				//If num ber = 2, execute Training Directory Data function
				else if (numberChosen == 2) 
				{
					DirectoryData ();
				}
				//If number = 3, break this loop
				else if (numberChosen == 3) 
				{
					break;
				}
			}

		}



		private void WriteFile()
		{
			//WRITE TO TEXT FILE//

			//Add a line to the string text
			//s += "A new line. \n";

			//Hook a write to text file
			//StreamWriter writer = new StreamWriter(FileName);

			//Rewrite the entire value of s to the file
			//writer.Write(s);

			//Add a single line
			//writer.WriteLine("Added another line.");

			//Close the writer
			//writer.Close();
		}
	}
}
