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

            PracticalLesson Practice1 = new PracticalLesson("First practical lesson", "Do math", "Solved");

            PracticalLesson Practice2 = new PracticalLesson("Second practical lesson", "Do physics", "Trying");

            Lecture Lecture1 = new Lecture("First lecture", "C#");

            Console.WriteLine();


            Training1.Add(Practice1);
            Training1.Add(Practice2);
            Console.WriteLine(Training1.ToString());

            var CopyOfTraining = (Training)Training1.Clone();

            Console.WriteLine(Training.IsPractical(Training1.Trainingslist));
            Console.WriteLine(CopyOfTraining.ToString());

            Training1.Add(Lecture1);
            Console.WriteLine();

            Console.WriteLine(Training.IsPractical(Training1.Trainingslist));

            var CopyOfTraining2 = (Training)Training1.Clone();
            Console.WriteLine();

            
            Console.WriteLine();
            Console.WriteLine(Training1.ToString());

            Console.WriteLine(CopyOfTraining2.ToString());


        }
    }
}
