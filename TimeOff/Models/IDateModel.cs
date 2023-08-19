namespace TimeOff.Models;

	public interface IDateModel
	{
        DateTime StartTime { get; }
        DateTime EndTime { get; init; }
    }
