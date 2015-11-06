using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceLibrary
{
    public class Die
    {
        private Random randNum;
        private int _value;

        public int Value
        {
            get
            {
                return _value;
            }
        }
        
        public Die(int val)
        {
            if ((val < 1) || (val > 6))
            {
                throw new ArgumentOutOfRangeException();
            }

            randNum = new Random();
            _value = val;
        }
        
        public void Roll()
        {
            _value = randNum.Next(1, 7);
        }
    }
}
