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

            // Fixed the violation of the Law of Demeter
            bool isDoorOpen = myHouse.IsDoorOpen(); // Directly ask the house if the door is open

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

        // Method to encapsulate the check if the door is open
        public bool IsDoorOpen()
        {
            return door.IsOpen();
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
