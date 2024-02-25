using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Classes
{
    class CarPart
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }

        public CarPart(string name, string imagePath)
        {
            Name = name;
            ImagePath = imagePath;
        }
    }
}
