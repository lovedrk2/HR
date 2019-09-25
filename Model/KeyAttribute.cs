using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class KeyAttribute:Attribute
    {
        public string KeyName { get; set; }

        public KeyAttribute(string name)
        {
            KeyName = name;
        }
    }
}
