using System;

namespace NumberManager.Models
{
  public class NumberManager
  {
    public string UserNumber {get;set;}
    public NumberManager(string userNumber)
    {
      char[] arr = userNumber.ToCharArray();
      Array.Reverse(arr);
      string stringForm = new string(arr);
      UserNumber = stringForm;
    }


  }
}