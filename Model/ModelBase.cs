using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class ModelBase
    {

        private List<string> list = new List<string>();

        public void AddName(string name)
        {
            if (!list.Contains(name))
            {
                list.Add(name);
            }
        }

        public string GetName(int index)
        {
            return list[index];
        }

        public int GetCount()
        {
            return list.Count;
        }
    }
}
