using System;

namespace module1
{
    public enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }
    class CalendarEvent
    {
        private string EventName;
        private  DaysOfWeek EventDay;
        public CalendarEvent(string eventName, DaysOfWeek eventDay)
        {
            EventName = eventName;
            EventDay = eventDay;
        }
        public string get_eventName()
        {
            return EventName;
        }

        public DaysOfWeek get_eventDay()
        {
            return EventDay;
        } 

        public override string ToString() => $"EventName: {get_eventName()}, EventDay: {get_eventDay()}";
    }


    class Program
    {
        static void Main(string[] args)
        {
            CalendarEvent calendarEvent = new CalendarEvent("sdkd", DaysOfWeek.Monday);
            Console.WriteLine(calendarEvent);

        }
    }
}