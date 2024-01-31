using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RabbitMQ_Library
{
    /// <summary>
    /// Validation Class to check if the name is correct
    /// </summary>
    public class ValidationClass
    {
        public string ValidateMessage(string message)
        {
            //Splits the message by the comma
            string[] parts = message.Split(',');

            //Check if there are at least two parts(before and after comma)
            if (parts.Length >= 2)
            {
                //Extract the text after the comma and remove leading/trailing whitespace/double quote
                string result = parts[1].Trim(new Char[] { ' ', '"' });
                return result;
            }
            else
            {
                //Returns a null value if the message doesn't contain a comma
                return null;
            }
        }
    }
}
//-------------------------------------End OF File------------------------------------------//

