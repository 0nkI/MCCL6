using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MCCL6
{
    internal class Car : IID
    {
        public int Id { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }

        public Car(string carBrand, string carModel)
        {
            CarBrand = carBrand;
            CarModel = carModel;
        }
        public override string ToString()
        {
            return string.Format(Id + " " + CarBrand + " " + CarModel);
        }
    }
}
