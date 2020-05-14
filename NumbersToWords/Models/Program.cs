using System;
using NumberManager.Models;
using System.Collections.Generic;

namespace NumberManager.Models{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Hello! Give me a number in numerical form (ex: 123345) and I will convert it to plain English!");
      string userInput = Console.ReadLine();
      NumberManager myObject = new NumberManager(userInput);
      
      Dictionary<char, string> onesDict = new Dictionary<char, string>() 
      {['1'] = " one", ['2'] = " two", ['3'] = " three", ['4'] = " four", ['5'] = " five", ['6'] = " six", ['7'] = " seven", ['8'] = " eight", ['9'] = " nine", ['0'] = ""};
      Dictionary<char, string> tensDict = new Dictionary<char, string>() 
      {['2'] = " twenty", ['3'] = " thirty", ['4'] = " fourty", ['5'] = " fifty", ['6'] = " sixty", ['7'] = " seventy", ['8'] = " eighty", ['9'] = " ninety", ['0'] = ""};
      Dictionary<string, string> teensDict = new Dictionary<string, string>() 
      {["10"] = "ten", ["11"] = " eleven", ["12"] = " twelve", ["13"] = " thirteen", ["14"] = " fourteen", ["15"] = " fifteen", ["16"] = " sixteen", ["17"] = " seventeen", ["18"] = " eighteen", ["19"] = " nineteen"};

      int index = 0;
      int limit = myObject.UserNumber.Length;
      string resultingString = "";
      string newEntry = "";

      while (index < limit )
      {
        switch(index%3)
        {
          case 0:
            if (myObject.UserNumber[index+1] == 1)
            {
              index += 1;
              goto case 1;
            }
            newEntry = onesDict[myObject.UserNumber[index]];
            MagnitudeCheck:
            if (myObject.UserNumber[index] != '0')
            {
              switch(index/3)
              {
                case 0: 
                break;
                case 1:
                  newEntry = newEntry + " thousand";
                  break;
                case 2:
                  newEntry = newEntry + " million";
                  break;
                case 3:
                  newEntry = newEntry + " billion";
                  break;
                case 4:
                  newEntry = newEntry + " trillion";
                  break;
                case 5:
                  newEntry = newEntry + " quadrillion";
                  break; 
                case 6:
                  newEntry = newEntry + " quintillion";
                  break;
                case 7:
                  newEntry = newEntry + " sextillion";
                  break;
                case 8:
                  newEntry = newEntry + " septillion";
                  break;
                case 9:
                  newEntry = newEntry + " octillion";
                  break;
                case 10:
                  newEntry = newEntry + " nonillion";
                  break;
                case 11:
                  newEntry = newEntry + " decillion";
                  break;
              }
            }
            break;
          case 1:
            if (myObject.UserNumber[index] == '1')
            {
              string teensEntry = "1" + myObject.UserNumber[index - 1];
              newEntry = teensDict[teensEntry];  
              goto MagnitudeCheck;
            }
            else
            {
              newEntry = tensDict[myObject.UserNumber[index]];
            }
            break;
          case 2:
            newEntry = onesDict[myObject.UserNumber[index]] + " hundred";
            break;
        }

        
        resultingString = newEntry + resultingString;

        index += 1;
      }
      
    Console.WriteLine(resultingString);
    }
  }
}