using System;
using System.Reflection;
using System.Collections.Generic;

namespace Task2TrainingManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Training Training1 = new Training("Training 1 description");

            Training Practice1 = new PracticalLesson("First practical lesson", "Do math", "Solved");

            Training Practice2 = new PracticalLesson("Second practical lesson", "Do physics", "Trying");

            foreach (object element in Training.Trainingslist)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();

            Console.WriteLine(Practice2.IsPractical(Training.Trainingslist));


            Training Lecture1 = new Lecture("First lecture", "C#");

            foreach (object element in Training.Trainingslist)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();

            Console.WriteLine(Practice2.IsPractical(Training.Trainingslist));

            var CopyOfTraining = (Training)Training1.Clone();

            Console.WriteLine(Training1.Description);
            Console.WriteLine(Practice2.Description);
            //Console.WriteLine(CopyOfTraining.Sum());
            Console.WriteLine(CopyOfTraining.Description);

        }
    }
}
