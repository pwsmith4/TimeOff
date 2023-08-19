namespace TimeOff.Models;

public class DateModel : IDateModel
{
    private DateTime _startTime;

    /// <summary>
    /// This is the time the entry was created. This should not be modified by the user.
    /// </summary>
    public DateTime StartTime
    {
        get { return _startTime; }
        init { _startTime = value; }
    }
    
    private DateTime _endTime;

    /// <summary>
    /// This is the time the entry was created. This should not be modified by the user.
    /// </summary>
    public DateTime EndTime
    {
        get { return _endTime; }
        init { _endTime = value; }
    }
    public DateModel()
	{
        var date = DateTime.Now;
        StartTime = date;
        EndTime = date;
	}


}