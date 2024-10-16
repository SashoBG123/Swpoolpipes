using Swpool.Model;
using Swpool.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swpool.Controller
{
    internal class PoolActionController
    {
        // Обекти от класовете Display и Pool
        Display currentDisplay;
        Pool currentPool;

        // Конструктор
        public PoolActionController()
        {
            currentDisplay = new Display();
            currentPool = new Pool();
        }

        // Метод за стартиране на процеса
        public void Start()
        {
            currentDisplay.Input();
            this.currentPool.Volume = this.currentDisplay.V;
            this.currentPool.Pipe2FlowRate = this.currentDisplay.P2;
            this.currentPool.Pipe1FlowRate = this.currentDisplay.P1;
            this.currentPool.Hours = this.currentDisplay.H;
            this.currentDisplay.TotalWater = this.currentPool.TotalWater();
            currentDisplay.Output();

        }
    }
}
