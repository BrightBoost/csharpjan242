using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace OOProject
{
/*    Create a class car, give it some properties that make sense

Add a method start, that returns true when the engine has started successfully and false when it didn’t.

And: make it start successfully 7/10 times and make it fail to start 3/10 times.

And also: add a method to increase speed, that increases the speed by the given input, but won’t go over the maxspeed of the car.

Make an instance of the Car, and start the car.*/

    internal class ExerciseCar
    {
        public string Color { get; set; } = "black";
        public bool IsRunning { get; set; }
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;

        public ExerciseCar(string color, int maxSpeed) {
            Color = color;
            MaxSpeed = maxSpeed;
        }

        public ExerciseCar() { }

        public bool Start()
        {
            int lucky = new Random().Next(1, 10);
            if(lucky < 7)
            {
                IsRunning = true;
                return true;
            } 
            else
            {
                IsRunning = false;
                return false;
            }
        }

        public bool Start(int chance)
        {
            int lucky = new Random().Next(1, 100);
            if (lucky < chance)
            {
                IsRunning = true;
                return true;
            }
            else
            {
                IsRunning = false;
                return false;
            }
        }

        public void IncreaseSpeed(int speed)
        {
            if (IsRunning && CurrentSpeed + speed > MaxSpeed)
            {
                CurrentSpeed = MaxSpeed;
            }
            else if(IsRunning)
            {
                CurrentSpeed = CurrentSpeed + speed;
            }
        }
    }
}
