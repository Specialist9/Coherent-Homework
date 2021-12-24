using System;

namespace Task2TrainingManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Training NewTraining = new Training("New T description");
            Training Lecture1 = new Lecture("First lecture", "C#");

            /*foreach (object element in Training.Trainingslist)
            {
                Console.WriteLine(element);
            }*/

            Console.WriteLine();

            Training Practice1 = new PracticalLesson("First practical lesson", "Do math", "Solved");

            
            /*foreach(object element in Training.Trainingslist)
            {
                Console.WriteLine(element);
            }*/

            Console.WriteLine();

            Training Practice2 = new PracticalLesson("Second practical lesson", "Do physics", "Trying");


            foreach (object element in Training.Trainingslist)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();
            //Console.WriteLine(Training.Trainingslist[2].Solution);

            Console.WriteLine(Practice2.IsPractical(Training.Trainingslist));

            Console.WriteLine(Practice2.Clone());

            var CopyOfTraining = Practice2.Clone();
            
            foreach (object element in CopyOfTraining.Trainingslist)
            {
                Console.WriteLine(element);
            }

        }
    }
}
