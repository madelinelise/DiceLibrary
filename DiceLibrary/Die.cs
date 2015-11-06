using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceLibrary
{
    public class Die
    {
        Random randomValue = new Random();

        int _value;
        bool _isHeld;
        

        public int Value
        {
            get { return _value; }
            private set
            {
                if (value < 1 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("The value must be 1-6");
                }
                else
                {
                    _value = value;
                }
            }
        }

        public bool IsHeld
        {
            get { return _isHeld; }
            set { _isHeld = value; }
        }

        public Die(int diceValue)
        {            
            _value = diceValue;
            _isHeld = false;
        }

        public void Roll()
        {
            try
            {
                if (IsHeld == true )
                Value = new Random().Next(1, 7);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                System.ArgumentException argEx = new System.ArgumentException("Index is out of range", "index", ex);
                throw argEx;
            }

        }


    }
}
