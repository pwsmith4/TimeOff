namespace TimeOff.Models;

public class TimeOffRequest
{
    public int Id { get; set; }
    public string StartTime { get; set; }
    public string EndTime { get; set; }
}