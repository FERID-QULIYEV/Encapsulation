using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Encapsulation.Model
{
    internal class Student
    {
        private string _name;
        public string _surname;
        private sbyte _avgPoint;
        public string Name
        {
            set
            {
                _name=value.Trim();
            }
            get
            {
                return _name;
            }
        }
        public string Surname
        {
            set
            {
                _surname = value.Trim();
            }
            get
            {
                return _surname;
            }
        }

        public sbyte AvgPoint
        {
            set
            {
                if (_avgPoint <= 100 && _avgPoint >= 0 )
                {
                    _avgPoint = value;
                }
            }
            get
            {
                return _avgPoint;
            }
        }

    }
    
}
