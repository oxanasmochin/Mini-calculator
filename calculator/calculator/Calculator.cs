using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Calculator
    {
       public float ack;
 

        public Calculator (float x)
        {
           this.ack=x;
         
        }
        public void Sum(float x)
        {
            ack = ack + x;
        }
        public void Mul(float x)
        {
            ack = ack * x;
        }
        public void Div(float x)
        {
                ack = ack / x;
        }
        public void Sub(float x)
        {
            ack = ack-x;
        }

        public float Reset()
        {
            return ack = 0;
        }
        public float execute()
        {
            return ack;
        }
    }
}
