using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceLibrary
{
    public class YahtzeeRoller
    {
        Die dieObject = new Die(0);

        Die[] Dice = new Die[6];
        Random randomValue = new Random();

        private int _rollCount;

        public int RollCount
        {
            get { return _rollCount; }
            set { _rollCount = value; }
        }


        private int _keep;

        public int _Keep
        {
            get { return _keep; }
            set {
                _keep = value;
                }
        }

        public void Keep(  )
        {
           dieObject.IsHeld = true;
        }
    

        public void CreateDice()
        {
            for (int i = 0; i <= 6; i++)
            {
                Dice[i] = new Die(randomValue.Next(1,7));    
            }

            return Dice[i];
        }

        public void NewTurn()
        {
            
        }
            

       
    }
}
