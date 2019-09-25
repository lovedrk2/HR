using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Key("Id")]
    public class StudentModel:ModelBase
    {
        private int _Id;
        private string _Name;

        public int Id
        {
            get
            {
                return _Id;
            }

            set
            {
                _Id = value;
                AddName("Id");
            }
        }

        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                _Name = value;
                AddName("Name");
            }
        }
    }
}
