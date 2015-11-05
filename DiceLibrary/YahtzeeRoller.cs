using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceLibrary
{
    public class YahtzeeRoller
    {

        Die[] Dice = new Die[6];
        Random randomValue = new Random();

        private bool _keep;

        public bool Keep
        {
            get { return _keep; }
            set { _keep = value; }
        }

        public void CreateDice()
        {
            for (int i = 0; i <= 6; i++)
            {
                Dice[i] = new Die(randomValue.Next(1,7));    
            }

        }
    }
}
