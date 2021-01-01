using System;


namespace HomeworkObjectsLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int arraySize = 5;
            TrainSchedule trainSchedule = new TrainSchedule();
            trainSchedule.ConcoleTextColor();
            trainSchedule.FillingInTheTrainSchedule(ref arraySize);
            trainSchedule.ShowInTheTrainSchedule();



            Console.ReadLine();
        }


    }
    public partial class TrainSchedule
    {

        public void ConcoleTextColor()
        {            
            Console.ForegroundColor = ConsoleColor.Green;

        }
    }

} 
