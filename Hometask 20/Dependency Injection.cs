using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public interface IEngine
    {
        void TurnOnTheEngine();
    }
    class SmallEngine : IEngine
    {
        public void TurnOnTheEngine()
        {
            Console.WriteLine($"{this.GetType().Name} is ON!");
        }
    }

    class BigEngine : IEngine
    {
        public void TurnOnTheEngine()
        {
            Console.WriteLine($"{this.GetType().Name} is ON!");
        }
    }

    public class Automobile
    {
        private IEngine _engine;
        //public Automobile(IEngine engine)
        //{
        //    this._engine = engine;
        //}
        public IEngine Engine
        {
            set
            {
                this._engine = value;
            }
        }

        public void TurnOn()
        {
            _engine.TurnOnTheEngine();
        }
    }

}
