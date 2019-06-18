using System;
using System.Net;
using System.IO;

namespace csharpclass
{

    abstract class Animal
    {
        public virtual void Walk()
        {
            // walk on four legs
        }
    }



    class Cat : Animal
    {
        new void Walk(){
            
        }
    }


    public abstract class AbstractCar{
        public void Drive(){
            ///
        }
    }

    public interface ICar
    {
        void Drive();
        void Park();
    }

    public interface IVehicle
    {
        void Reverse();
        void Drive();
    }

    class ManualCar : ICar, IVehicle
    {
        public void Drive()
        {
            
        }

        public void Park()
        {
            throw new NotImplementedException();
        }

        public void Reverse()
        {
            throw new NotImplementedException();
        }
    }

    class AutomaticCar : ICar, IVehicle
    {

        public void Lock()
        {

        }

        public void Start()
        {

        }

        public void Drive()
        {
            //Automatic tran
        }

        public void Park()
        {
            throw new NotImplementedException();
        }

        public void Reverse()
        {
            throw new NotImplementedException();
        }
    }
}