namespace TimeOff.Utils;

public static class MethodExtensions
{
    private const string ErrorMessage = "Something went wrong, Please try again.";

    /// <summary>
    /// Wraps task in try / catch block
    /// </summary>
    /// <param name="task"></param>
    /// <returns></returns>
    public static async Task WrapTaskInTryCatch(Task task)
    {
        try
        {
            await task;
        }
        catch (Exception ex)
        {
            //Generic exception handling
            //TODO: Differentiate between 4xx and 5xx i.e. 'incorrect creds' or 'server error'
            await Shell.Current.DisplayAlert("Error", ErrorMessage, "OK");
        }
        finally
        {
        }
    }
}
    /*
    /// <summary>
    /// Wraps task in BusyIndicatorView
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="task"></param>
    /// <param name="loadingText"></param>
    /// <returns></returns>
    public static async Task<T> WrapTaskInBusyIndicator<T>(Task<T> task, string loadingText = "Loading...")
    {
        var popup = new BusyIndicatorView() { BusyText = loadingText };
        App.Current.MainPage.ShowPopup(popup);

        try
        {
            return await task;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            popup.Close();
        }
    }

    /// <summary>
    /// Wraps task in BusyIndicatorView
    /// </summary>
    /// <param name="task"></param>
    /// <param name="loadingText"></param>
    /// <returns></returns>
    public static async Task WrapTaskInBusyIndicator(Task task, string loadingText = "Loading...")
    {
        var popup = new BusyIndicatorView(loadingText);
        App.Current.MainPage.ShowPopup(popup);

        try
        {
            await task;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            popup.Close();
        }
    }
}
    */