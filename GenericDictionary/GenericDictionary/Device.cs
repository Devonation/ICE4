using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDictionary
{
    internal class Device
    {
        public Device(string name, int rAM, int storage)
        {
            Name = name;
            RAM = rAM;
            Storage = storage;
        }

        public string Name { get; set; }
        public int RAM { get; set; }
        public int Storage { get; set; }
        
    }
}
