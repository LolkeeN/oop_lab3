using System;
using System.Collections.Generic;
using System.Text;

namespace Veselov_V_O_oop_lab3
{
    abstract class CGraphicsObject : NameDisplayer
    {
        public String name;
        public void displayName()
        {
            Console.WriteLine(name);
        }
        public String getName() {
            return name;
        }

        public void setName(String name) {
            this.name = name;
        }
    }
}
