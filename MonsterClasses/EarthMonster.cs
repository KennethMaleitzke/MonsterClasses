using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    class EarthMonster : Monster, IBattle
    {
        private string _home;

        public string Home
        {
            get { return _home; }
            set { _home = value; }
        }

        public override string Greeting()
        {
            return $"Hello, my name is {base.Name} and I am from the {_home} here on Earth.";
        }

        public override bool IsHappy()
        {
            return false;
        }

        public MonsterAction MonsterBattleResponse()
        {
            Random randomNumber = new Random(25);
            int battleResponseNumber = randomNumber.Next(0, 101);

            if (battleResponseNumber >= 66)
            {
                return MonsterAction.Attack;
            }
            else if (battleResponseNumber >= 33)
            {
                return MonsterAction.Defend;
            }
            else
            {
                return MonsterAction.Retreat;
            }
        }
    }
}
