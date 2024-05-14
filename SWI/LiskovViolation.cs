using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWI
{
    public class LiskovViolation : IDemo
    {
        public void RunExample()
        {
            Bird myBird = new Penguin();
            myBird.Eat();
            //myBird.Fly(); // not implemented

            IFlyable myFlyableBird = new Eagle();
            myFlyableBird.Fly();
        }
    }

    public abstract class Bird
    {
        public abstract void Eat();
    }

    public interface IFlyable
    {
        void Fly();
    }

    public class Eagle : Bird, IFlyable
    {
        public override void Eat()
        {
            Console.WriteLine("Eagle is eating.");
        }

        public void Fly()
        {
            Console.WriteLine("Eagle flying high!");
        }
    }

    public class Penguin : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Penguin is eating.");
        }
    }
}
