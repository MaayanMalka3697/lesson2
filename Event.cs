namespace Lesson2
{
    public class Event
    {
       public int id;
       public string title;
       public DateTime start;
       public DateTime end;

        public Event(int id, string title, DateTime start, DateTime end)
        {
            this.id = id;
            this.title = title;
            this.start = start;
            this.end = end;
        }
    }
}
