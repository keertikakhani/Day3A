using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Day3A
{
    // Encapsulation example
    public class UserName
    {
        private string name;

        public string Name
        {
            set
            {
               name = value;
            }
            get
            {
                return name;
            }
        }
    }
}
