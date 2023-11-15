using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class TimeFormatException:Exception
    {
        public  new string Message;
        
       public TimeFormatException(string message)
        {
            Message=message;
           
        }

    }
}
