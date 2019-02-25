using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    public class SpaceMonster : Monster, IBattle
    {
        private string _galaxy;
        private bool _hasWings;

        public string Galaxy
        {
            get { return _galaxy; }
            set { _galaxy = value; }
        }

        public bool HasWings
        {
            get { return _hasWings; }
            set { _hasWings = value; }
        }


        public override string Greeting()
        {
            return $"Hello, my name is {base.Name} and I am from the {_galaxy} galaxy.";
        }

        public override bool IsHappy()
        {
            return true;
        }

        public MonsterAction MonsterBattleResponse()
        {
            Random randomNumber = new Random();
            int battleResponseNumber = randomNumber.Next(0, 101);

            if (battleResponseNumber >= 66)
            {
                return MonsterAction.Attack;
            }
            else if(battleResponseNumber >= 33)
            {
                return MonsterAction.Defend;
            }
            else
            {
                return MonsterAction.Retreat;
            }
        }
        public override bool HasWings()
        {
            return _hasWings ? true : false;
        }
        
    }
}
