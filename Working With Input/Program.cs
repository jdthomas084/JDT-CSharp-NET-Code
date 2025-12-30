using System;
using System.IO;
using File = System.IO.File;

class Program
{ 
    public static void Main()
    {
        string fileInput = @"Input.txt";//Input file stored in the root directory
        if (File.Exists(fileInput))//If the program 'finds' the file, do this:
        {
            // Reads file line by line
            var Textfile = new StreamReader(fileInput);//Open a new StreamReader
            int usrCt = 0;//Declare an initial User Count
            string line;
            char separator = ',';//Define the separator to Get [Name, Age] on each line of text

            while ((line = Textfile.ReadLine()) != null)//Execute the following code when you have a non-NULL line of text
            {
                usrCt++;//Increment User Count (total)

                string[] spl = line.Split(separator);//Can also be done in Python

                if ((int.Parse(spl[1]) > 18) && ((usrCt > 100) && (usrCt < 201)))//Cond1: the Value of "age" is Greater Than 18  Cond2: The streamReader is looking at the 101th User and reads until User # 201, where it stops
                {
                    string user = spl[0];//Get the Name, the piece before the 'separator' char
                    System.Console.WriteLine(user);//Display Users only who are over 18 years of age
                }
            }

            Textfile.Close();//Close the StreamReader
        }
    }
}