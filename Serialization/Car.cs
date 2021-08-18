using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Serialization
{
    [Serializable]
    public class Car
    {
        public uint MaxSpeed { get; set; }
        public string Model { get; set; }

        public Car() { }
        public Car(uint MaxSpeed, string Model)
        {
            this.MaxSpeed = MaxSpeed;
            this.Model = Model;
        }


    }
}