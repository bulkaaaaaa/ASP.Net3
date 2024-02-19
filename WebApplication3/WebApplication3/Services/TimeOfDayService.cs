namespace WebApplication3.Services
{
    public class TimeOfDayService : ITimeOfDayService
    {
        public string GetTimeOfDay()
        {
            var currentTime = DateTime.Now;
            var hour = currentTime.Hour;

            if (hour >= 12 && hour < 18)
                return "It's day now";
            else if (hour >= 18 && hour < 24)
                return "It's evening now";
            else if (hour >= 0 && hour < 6)
                return "It's night now";
            else
                return "It's morning now";
        }
    }
}
