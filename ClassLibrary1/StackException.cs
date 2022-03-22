using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

   public class StackException:Exception
    {
       // String message;
        public  StackException(String message) : base(message)
        {
            // base(message);  // Calls Exception's constructor    
        }
    }
}
