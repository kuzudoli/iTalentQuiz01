using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Polymorphism_Interface_Encapsulation
{
    //We have 2 player type, one is normal player and other one game manager.
    //Game manager has the same prop with normal players...
    //...but they are powerfull then others and they have higher level.
    //So we're declaring virtual Level prop and PowerCalculate method
    internal class Player
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public virtual int Level { get; set; } = 1;

        public virtual int PowerCalculation()
        {
            return Level * 5;
        }
    }

    internal class GameManager : Player
    {
        public override int Level { get; set; } = 100;
        public override int PowerCalculation()
        {
            return Level * 100;
        }
    }
}
