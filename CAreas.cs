﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class CAreas
    {
        private static decimal area; 

        public static decimal Area
        {
            get
            { 
                return area; 
            }
            set
            {
                area = value; 
            }
        }

        public CAreas()
        {
            area = 0;
        }

        public static decimal Cuadrado(decimal lado)
        {
            area = lado * lado;
            return area;
        }

        public static decimal Triangulo(decimal b, decimal h)
        {
            area = (b*h)/2;
            return area;
        }

        public static decimal Rectangulo(decimal b, decimal h)
        {
            area = b*h;
            return area;
        }

        public static decimal Romboide(decimal b, decimal h)
        {
            area = b * h;
            return area;
        }


        public static decimal Rombo(decimal D, decimal d)
        {
            area = D * d;
            return area;
        }
    }
}
