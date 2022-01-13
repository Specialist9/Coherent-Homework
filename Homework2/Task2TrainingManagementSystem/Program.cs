using System;
using System.Reflection;
using System.Collections.Generic;

namespace Task2TrainingManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var originalTraining = new Training("desc1");
            Lecture lecture = new Lecture("First lecture", "C#");
            Lecture lecture2 = new Lecture("Second lecture", "more C#");

            originalTraining.Add(lecture);
            originalTraining.Add(lecture2);

            Console.WriteLine(lecture.Topic);
            Console.WriteLine(lecture2.Topic);
            Console.WriteLine();

            var clonedTraining = (Training)originalTraining.Clone();


            lecture.Topic = "The updated topic!";
            lecture2.Topic = "Update of second lecture";

            Console.WriteLine(lecture.Topic);
            Console.WriteLine(lecture2.Topic);
            Console.WriteLine();

            var clonedLecture10 = (Lecture)clonedTraining.Trainingslist[0];
            var clonedLecture11 = (Lecture)clonedTraining.Trainingslist[1];

            Console.WriteLine(clonedLecture10.Topic);
            Console.WriteLine(clonedLecture11.Topic);


            Console.WriteLine(clonedLecture10 == lecture);
            Console.WriteLine(clonedLecture11 == lecture2);

            
        }
    }
}
