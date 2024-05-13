using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWI
{
    public class DemeterViolation : IDemo
    {
        public void RunExample()
        {
            House myHouse = new House();

            // Violating the Law of Demeter by accessing a method of an object returned by another method
            bool isDoorOpen = myHouse.GetDoor().IsOpen();

            Console.WriteLine("Is the door open? " + (isDoorOpen ? "Yes" : "No"));
        }
    }

    public class House
    {
        private Door door;

        public House()
        {
            door = new Door();
        }

        // Method to return the Door object
        public Door GetDoor()
        {
            return door;
        }
    }

    public class Door
    {
        private bool isOpen = false;

        public bool IsOpen()
        {
            return isOpen;
        }
    }
}
