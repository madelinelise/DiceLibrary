using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceLibrary
{
    public class YahtzeeRoller
    {

        Die[] Dice = new Die[6]; // { new Die(1), new Die(1), new Die(1), new Die(1), new Die(1), new Die(1) };
        int _rollCount = 0;
        bool[] _keep = new bool[6];

        public YahtzeeRoller()
        {
            for (int i = 0; i < 5; i++)
            {
                Dice[i] = new Die(1);
            }
        }
        
        public void Keep( int val )
        {
            _keep[val] = true;
        } 

        public void ReleaseDie( int val)
        {
            _keep[val] = false;
        }

        public void RollDice()
        {
            if (_rollCount >= 3)
            {
                throw new IndexOutOfRangeException("You can only roll 3 times.");
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    if(!_keep[i])
                    {
                        Dice[i].Roll();
                    }
                }
                _rollCount++;
            }
        }

        public Die[] ShowDice()
        {
            return Dice;
        }

        public void NewTurn()
        {
            _rollCount = 0;

            for (int i = 0; i < 5; i++)
            {
                _keep[i] = false;
            }
        }

    }
}
