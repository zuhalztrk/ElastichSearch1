using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElastichSearch1
{
    public class car
    {

        public car(string make,int price )
        {
            make = make;
            price = price;
        }
        public string Make { get; set; }
        public int price { get; set; }
    }
}
