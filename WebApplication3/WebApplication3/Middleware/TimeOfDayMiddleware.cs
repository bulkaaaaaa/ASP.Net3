using Microsoft.Extensions.Logging;
using WebApplication3.Services;

namespace WebApplication3.Middleware
{
    public class TimeOfDayMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ITimeOfDayService _timeOfDayService;
        private readonly ILogger<TimeOfDayMiddleware> _logger;

        public TimeOfDayMiddleware(RequestDelegate next, ITimeOfDayService timeOfDayService)
        {
            _next = next;
            _timeOfDayService = timeOfDayService;
        }


        public async Task Invoke(HttpContext context)
        {
            await _next(context);

            var timeOfDay = _timeOfDayService.GetTimeOfDay();
            await context.Response.WriteAsync($"   {timeOfDay}");

        }
    }
}
