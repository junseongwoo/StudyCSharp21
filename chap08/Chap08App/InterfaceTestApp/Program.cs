using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTestApp
{
    // 다중 상속으로 하면 Ride를 어떤것을 써야하는지 인식하지 못해 오류를 발생한다.
    // Interface를 사용하여 해결한다.
    /* class Ridable // 탈것
     {
         public virtual void Ride()
         {
             Console.WriteLine("탈것!");
         }
     }*/
    interface ICar
    {
        void Run();
        void Ride();
    }

    interface IPlane
    {
        void Fly();
        void Ride();

    }
    class DroneCar : IPlane, ICar
    {
        public void Fly()
        {
            Console.WriteLine("드론카 날다");
        }

        public void Ride()
        {
            Run();
            Fly();
        }

        public void Run()
        {
            Console.WriteLine("드론카 달리다.");
        }
    }
    /*class car : Ridable
    {
        public void Run()
        {
            Console.WriteLine("달려!");
        }
        
        public override void Ride()
        {
            base.Ride();
            this.Run();
        }
    }*/

    /*class AirPlane : Ridable // 상속 
    {
        public void Fly ()
        {
            Console.WriteLine("날아!!");
        }

        public override void Ride()
        {
            base.Ride();
            this.Fly();
        }
    }*/
    class Program
    {
        static void Main(string[] args)
        {
            DroneCar dreamCar = new DroneCar();
            dreamCar.Ride();
        }
    }
}
