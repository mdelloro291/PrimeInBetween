using System;
using System.IO;

class Program {
	static string fileName = @"input.txt";

	public static void Main (string[] args) {
		
		if(File.Exists(fileName))
		{
			StreamReader file = new StreamReader(fileName);
			string line;

			while((line = file.ReadLine()) != null){
				string[] inputs = line.Split(',');

				
				int start;
				int end;
				int sumOfPrime = 0;

				bool primeFound = false;

				string primeString = "";
				string prime = "{0:#,}";
				string primeOutput = "Prime numbers from {0:#,0} to {1:#,0} are {2:#,0}";
				string sumOutput = "The sum of all prime numbers from {0:#,0} to {1:#,0} is {2:#,0}.";
				// Start integer check
				if(Int32.TryParse(inputs[0], out start) == true)
				{
					if(Int32.TryParse(inputs[1], out end) == true)
					{
						// Check if Start < End
						if(start < end){
							for(int countOne = start; countOne <= end; ++countOne){
								// Check number for divisibility
								
								for(int countTwo = 2; countTwo < countOne / 2; ++countTwo){
									// Check current number for divisibility
									if(countOne % countTwo == 0){
										primeFound = false;
										break;
									}
									primeFound = true;
								}
								// Check if Prime Number is found
								if(primeFound){
									sumOfPrime += countOne;
									primeString += String.Format(prime, countOne + " ");
								}
							}
							
							// Output Message Printing
							Console.WriteLine(String.Format(primeOutput, start, end, primeString));
							Console.WriteLine(String.Format(sumOutput, start, end, sumOfPrime));
						}
						// Start > End error message
						else{
							Console.WriteLine(String.Format("Input error. First number input {0} must be less than the second number input {1}.", start, end));
						}
					
					}
					
					// Non Numerical Error Message
					else
					{
						Console.WriteLine("Invalid input. Second number input must not be letters or special characters.");
					}
					
				}
				// Non Numerical Error Message
				else
				{
					Console.WriteLine("Invalid input. First number input must not be letters or special characters.");
				}
				Console.WriteLine("\n-----------------------------------------------------\n");
				//While Loop Closing Bracket
			}
			// If File Exists Closing Bracket
		}
		// PSVM Closing Bracket
	}
	//Class Closing Bracket
}