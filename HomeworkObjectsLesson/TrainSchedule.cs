using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkObjectsLesson
{
    public partial class TrainSchedule
    {
        private static DateTime date = DateTime.Now;
        private Train[] trains;
        private static string stationName = "Нурлы - жол";

        public TrainSchedule() { }
        static  TrainSchedule()
        {
            
        }       
        public DateTime GetDate()
        {
            return date;
        }
        public static string GetStationName()
        {
            return stationName;
        }
       
        public void FillingInTheTrainSchedule( ref int arraySize)
        {
            trains = new Train[arraySize];

            trains[0] = new Train(458, "пасс.", "Костанай - Тараз", 2, new TimeSpan(22, 50, 00), new TimeSpan(23, 00, 00));
            trains[1] = new Train(965, "скор.", "Петропавлоск - Алматы", 5, new TimeSpan(18, 30, 00), new TimeSpan(18, 50, 00));
            trains[2] = new Train(76, "пасс.", "Актау - Семей", 1, new TimeSpan(19, 15, 00), new TimeSpan(19, 30, 00));
            trains[3] = new Train(321, "скор.", "Кокшетау - Астана");
            trains[4] = new Train(36, "пасс.", "Москва - Бишкек", 3, new TimeSpan(12, 55, 00), new TimeSpan(13, 15, 00));

            

        }
        public void ShowInTheTrainSchedule()
        {
            Console.WriteLine("Расписание поездов \t\t " + GetDate());
            Console.WriteLine(GetStationName()+"\n");
            Console.WriteLine("№ Поезда\t Категория\t Назначение\t\t Прибытие\t Отправление\t Путь");
            Console.WriteLine($"{trains[0].GetTrainNumber()}\t\t {trains[0].GetCategoryName()}\t\t {trains[0].GetAppointment()}\t {trains[0].GetArrivalTime()}\t {trains[0].GetDepartureTime()}\t {trains[0].GetWay()}");
            Console.WriteLine($"{trains[1].GetTrainNumber()}\t\t {trains[1].GetCategoryName()}\t\t {trains[1].GetAppointment()}\t {trains[1].GetArrivalTime()}\t {trains[1].GetDepartureTime()}\t {trains[1].GetWay()}");
            Console.WriteLine($"{trains[2].GetTrainNumber()}\t\t {trains[2].GetCategoryName()}\t\t {trains[2].GetAppointment()}\t\t {trains[2].GetArrivalTime()}\t {trains[2].GetDepartureTime()}\t {trains[2].GetWay()}");
            Console.WriteLine($"{trains[3].GetTrainNumber()}\t\t {trains[3].GetCategoryName()}\t\t {trains[3].GetAppointment()}\t {trains[3].GetArrivalTime()}\t {trains[3].GetDepartureTime()}\t {trains[3].GetWay()}");
            Console.WriteLine($"{trains[4].GetTrainNumber()}\t\t {trains[4].GetCategoryName()}\t\t {trains[4].GetAppointment()}\t {trains[4].GetArrivalTime()}\t {trains[4].GetDepartureTime()}\t {trains[4].GetWay()}");

        }
    }
}
