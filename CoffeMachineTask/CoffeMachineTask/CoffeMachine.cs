﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoffeMachineTask
{
    class CoffeMachine : Machine
    {
        //Atribute
        private CoffePot pot;
        private WaterTank tank;
        private Capsule capsule;
        //Properties
        public CoffePot Pot
        {
            get { return pot; }
            set { pot = value; }
        }

        public WaterTank Tank
        {
            get { return tank; }
            private set { tank = value; }
        }

        public Capsule Capsule
        {
            get { return capsule; }
            set { capsule = value; }
        }

        //Constructor
        public CoffeMachine(string model, CoffePot cofpot) : base(model)
        {
            tank = new WaterTank(100);
            Pot = cofpot;
        }

        //Methods
        public override string Start()
        {
            base.Start();

            return Brew();
        }

        private string Brew()
        {
            if (CheckWaterLevel())
            {
                if (pot != null)
                {
                    Thread.Sleep(5000);
                    pot.CurrentCoffe = tank.CurrentWater;
                    tank.CurrentWater = 0;
                    OnOff = false;
                    return $"{Capsule.Type.ToString()} done";
                }
                else
                {
                    tank.CurrentWater = 0;
                    OnOff = false;
                    return "Water is all over the table";
                }
            }
            else
            {
                OnOff = false;
                return "Water level is too low";
            }
        }


        private bool CheckWaterLevel()
        {
            if (tank.CurrentWater == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }




    }
}
