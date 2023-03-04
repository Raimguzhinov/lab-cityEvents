namespace CityEvents.Models
{
    public class EventCategory
    {
        public readonly bool[] Categories = new bool[9];

        public EventCategory()
        {
            for (int i = 0; i < 9; i++)
            {
                Categories[i] = false;
            }
        }
    }
}