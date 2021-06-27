using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.MODEL
{
    public class Person
    {
        public int person_id { get; set; }
        public string name { get; set; }
        public double telephone { get; set; }
        public double number { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }

        public Person()
        {

        }
    }
}
