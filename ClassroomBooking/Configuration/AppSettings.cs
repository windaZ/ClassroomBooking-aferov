public class AppSettings
{
    public string AppTitle { get; get; set; } = "Classroom Booking";

    public string WorkDayStart { get; get; set; } = "08:00";

    public string WorkDayEnd { get; get; set; } = "20:00";

    public int MinBookingMinutes { get; get; set; } = 30;

    public bool AllowUnavailableRooms { get; get; set; } = false;

    public string StatusMessage { get; get; set; } = "Система готова к работе";
}
