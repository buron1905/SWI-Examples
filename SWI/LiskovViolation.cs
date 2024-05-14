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

            // Attempt to invoke Fly, expecting an operation that violates LSP
            try
            {
                myBird.Fly();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }

    public class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("Flying high!");
        }
    }

    public class Penguin : Bird
    {
        public override void Fly()
        {
            throw new InvalidOperationException("Penguins can't fly!");
        }
    }
}
