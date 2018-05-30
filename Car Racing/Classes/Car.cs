using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Racing.Classes
{
    /*●	Разработать абстрактный класс «автомобиль» (класс Car). 
Собрать в нем все общие поля, свойства (например, скорость) методы (например, ехать). */
    public delegate void Driving(Car car, float deistance);
    public delegate void Finish(Car car);
    public delegate void Ready(Car car);

    public abstract class Car
    {
        protected Ready readyHandler;

        public int Name { get; set; }
        public float Speed { get; set; }
        public float Distanse { get; set; }

        public abstract void Drive(float time, float limit);

        public abstract void GetReady();

        public event Ready Ready // событие
        {
            add { readyHandler += value; }
            remove { readyHandler -= value; }
        }
        public abstract event Finish Finish; // событие 
        public abstract event Driving Driving; // событие

    }
}
