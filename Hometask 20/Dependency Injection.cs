using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public interface Engine
    {
        void TurnOnTheEngine();
    }
    class SmallEngine : Engine
    {
        public void TurnOnTheEngine()
        {
            Console.WriteLine($"{this.GetType().Name} is ON!");
        }
    }

    class BigEngine : Engine
    {
        public void TurnOnTheEngine()
        {
            Console.WriteLine($"{this.GetType().Name} is ON!");
        }
    }

    public class Automobile
    {
        private Engine _engine;
        public Automobile(Engine engine)
        {
            this._engine = engine;
        }
        public void TurnOn()
        {
            _engine.TurnOnTheEngine();
        }
    }

}
