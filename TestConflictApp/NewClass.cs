using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConflictApp
{
    public static class NewClass
    {
        public static string GetHelloWorld(string msg)
        {
            string message = msg + " people!";
            return message;
        }
    }
}
