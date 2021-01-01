using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkObjectsLesson
{
    public class Train
    {
        private int trainNumber;
        private string categoryName;
        private string appointment;
        private int way;
        private TimeSpan arrivalTime;
        private TimeSpan departureTime;
        

        public Train() { }

        public Train(int trainNumber, string categoryName, string appointment)
        {
            if (trainNumber > 0)
            {
                this.trainNumber = trainNumber;
            }
            this.categoryName = categoryName;
            this.appointment = appointment;

        }

        public Train(int trainNumber, string categoryName, 
            string appointment, int way ,TimeSpan arrivalTime, TimeSpan departureTime)
        {
            if (trainNumber > 0)
            {
                this.trainNumber = trainNumber;
            }
            if(way > 0)
            {
                this.way = way;
            }
            this.categoryName = categoryName;
            this.appointment = appointment;
            this.arrivalTime = arrivalTime;
            this.departureTime = departureTime;

        }
        public int GetTrainNumber()
        {
            return trainNumber;
        }
        public void SetTrainNamber(int trainNumber)
        {
            if(trainNumber > 0)
            {
                this.trainNumber = trainNumber;
            }
        }
        public string GetCategoryName()
        {
            return categoryName;
        }
        public void SetCategoryName(string categoryName)
        {
            this.categoryName = categoryName;
        }
        public string GetAppointment()
        {
            return appointment;
        } 
        public void SetAppointment(string appointment)
        {
            this.appointment = appointment;
        }

        public int GetWay()
        {
            return way;
        }
        public void SetWay(int way)
        {
            if(way > 0)
            {
                this.way = way;
            }
        }

        public TimeSpan GetArrivalTime()
        {
            return arrivalTime;
        }
        public void SetArrivalTime(TimeSpan arrivalTime)
        {
            this.arrivalTime = arrivalTime;
        }
        public TimeSpan GetDepartureTime()
        {
            return departureTime;
        }
        public void SetDepartureTime(TimeSpan departureTime)
        {
            this.departureTime = departureTime;
        }



    }
}
