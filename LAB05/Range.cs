using System;

namespace LAB05
{
    public class Range
    {
        
        private double a;
        private double b;

        
        public double A
        {
            get { return a; }
            set
            {
                if (value > b) throw new 
                        ArgumentException("Левая граница не может быть больше правой");
                a = value;
            }
        }

        public double B
        {
            get { return b; }
            set
            {
                if (value < a) throw new 
                        ArgumentException("Правая граница не может быть меньше левой");
                b = value;
            }
        }

       
        public Range(double a, double b)
        {
            
            if (a > b) throw new 
                    ArgumentException("Левая граница не может быть больше правой");
            this.a = a;
            this.b = b;
        }

        
        public bool IsInside(double x)
        {
            return x >= a && x < b;
        }

        
        public void PrintRange()
        {
            Console.WriteLine($"Интервал: [{a}, {b})");
        }
    }
}