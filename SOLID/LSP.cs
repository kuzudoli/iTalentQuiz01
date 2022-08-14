using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SOLID
{
    internal interface IManuel
    {
        void GearUp();
        void GearDown();
    }
    internal abstract class Car
    {
        public abstract void Start();
    }

    internal class Tofas : Car, IManuel
    {
        public override void Start()
        {
            Console.WriteLine("Araç çalıştırıldı! (Tofaş)");
        }

        //This functions implenting from IManuel
        public void GearDown()
        {
            Console.WriteLine("Vites Yükseltildi! (Tofaş)");
        }
        public void GearUp()
        {
            Console.WriteLine("Vites Düşürüldü! (Tofaş)");
        }
    }

    internal class Tesla : Car
    {
        public override void Start()
        {
            Console.WriteLine("Araç çalıştırıldı! (Tesla)");
        }

        //There is no more need to override gear functions cause Tesla is not manuel car
    }
}
