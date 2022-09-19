using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ConstructorInheritence
{
    public class Car
    {
        public string TypeOfCar { get; set; }

        private int RegistrationNO { get; set; }

        // Here I am declaring the Constructor for the class Car

        public Car(int registrationNo)
        {
            this.RegistrationNO = registrationNo;
        }
    }
    public class Fortuner : Car
    {
      

        // Now we are not able the give the Constructor to the base class hence there is a way
        // of doing this by using the Constructor Inheritence

        private string OwenerName { get; set; }


        // Here i am defining the constructor with the derived class and Accesing the Ctor of the base Class
        // By using the base keyword
        // IMP whenever the ctor is called firstly the base will be called after that the derived ctor will be
        // Instantiated

        public Fortuner(int registrationNo, string owenerName) : base(registrationNo)
        {
            // This block will Contain the property which are seperated only for the derived class
            this.OwenerName = owenerName;
        }
    }
}
