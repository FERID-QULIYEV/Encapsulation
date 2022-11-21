using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Model
{
    internal class Group:Student
    {
        private string _no;
        private sbyte _studentLimit;
        private string[] _array;
        public string No
        {
            set
            {
                string Alphabeth = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                for (int i = 0; Alphabeth.Length > i; i++)
                {
                    _no = value;
                    if (Alphabeth[i] == _no[0])
                    {
                        continue;
                    }
                    else if( Alphabeth[i] == _no[1])
                    {
                        continue;
                    }
                    else
                    {
                        _no = "XXXXX";
                        //Console.WriteLine("Bele bir qrup yoxdur");
                    }
                }
                for (int i = 0; i < 10; i++)
                {
                    if (i == _no[2])
                    {
                        continue;
                    }
                    else if(i == _no[3])
                    {
                        continue;
                    }
                    else if (i == _no[4])
                    {
                        continue;
                    }
                    else
                    {
                        _no = "XXXXX";
                        //Console.WriteLine("Bele bir qrup yoxdur");
                    }
                }
            }
            get
            {
                return _no;
            }
    }
        public sbyte StudentLimit
        {
            set 
            {
                if (_studentLimit < 20 && _studentLimit > 0)
                {
                    Console.WriteLine(StudentLimit);
                    _studentLimit = value;
                } 
            }
            get { return _studentLimit; }
        }
        //public string[] AddStudent()
        //{

        //}
        //public string FilterByName()
        //{

        //}
    }


}
