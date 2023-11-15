using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class TimeConverter
    {
        public void startProgram()
        {
            Console.WriteLine("hallo, gi meg et klokkeslett i 24 timers format for å konvertere.");
            GetUserInput();
        }
        public void GetUserInput()
        {
            string userInput= Console.ReadLine();
            while (userInput == string.Empty)
            {
                userInput = Console.ReadLine();
            }
            HandelUserInput(userInput);
        }
       
        public void HandelUserInput(string userInput)
        {
            string[] returnedArray = userInput.Split(':');
            List<int> convertedNumbers = new();
            foreach (string s in returnedArray)
            {
                convertedNumbers.Add(Convert.ToInt32(s));

            }
            ConvertTime(convertedNumbers);
        }
        public void ConvertTime(List<int> numbersToConvert)
        {
            if (numbersToConvert[0] < 0 || numbersToConvert[0]>23|| numbersToConvert[1]<0|| numbersToConvert[1]>59)
            {
                throw new TimeFormatException("ugyldig kolokkeslett.");
            }
           else if (numbersToConvert[0] > 12)
            {
                numbersToConvert[0]= numbersToConvert[0] - 12;
            }
            else if (numbersToConvert[0] == 00)
            {
                numbersToConvert[0] = 12;
            }
            PrintConvertedTime( numbersToConvert);
        }
        public void PrintConvertedTime(List <int> numbersConverted)
        {
            Console.WriteLine($" klokken blir {numbersConverted[0]} : {numbersConverted[1]}");
        }
        
    }
}
