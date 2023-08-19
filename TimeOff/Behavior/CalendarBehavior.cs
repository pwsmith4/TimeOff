using System.ComponentModel;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.Messaging;
using Syncfusion.Maui.Calendar;

namespace TimeOff.Behavior
{
    public class CalendarBehavior : Behavior<SfCalendar>
    {
        private SfCalendar sfCalendar;
        private DateTime startDate;
        private DateTime endDate;


        public DateTime StartDate
        {
            get { return startDate; }
            set
            {
                startDate = value;
                OnPropertyChanged();
            }
        }

        // This method raises the PropertyChanged event with the name of the property that changed
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // This event is required by the INotifyPropertyChanged interface
        public event PropertyChangedEventHandler PropertyChanged;

        protected override void OnAttachedTo(SfCalendar bindable)
        {
            base.OnAttachedTo(bindable);
            this.sfCalendar = bindable;
            this.sfCalendar.SelectionChanged += SfCalendar_SelectionChanged;
        }
        // Define a message name
        public const string DatesSelectedMessage = "DatesSelected";

        private void SfCalendar_SelectionChanged(object sender, CalendarSelectionChangedEventArgs e)
        {
            if (this.sfCalendar.SelectedDateRange != null)
            {
                startDate = (DateTime)this.sfCalendar.SelectedDateRange.StartDate;
                if (this.sfCalendar.SelectedDateRange.EndDate != null)
                {
                    endDate = (DateTime)this.sfCalendar.SelectedDateRange.EndDate;
                }
                else
                {
                    endDate = (DateTime)this.sfCalendar.SelectedDateRange.StartDate;
                }
                // Send a message with the start date as the payload
                WeakReferenceMessenger.Default.Send(new StartDateChangedMessage(startDate));
                WeakReferenceMessenger.Default.Send(new EndDateChangedMessage(endDate));

            }
        }
        public record StartDateChangedMessage(DateTime StartDate);
        public record EndDateChangedMessage(DateTime EndDate);
        protected override void OnDetachingFrom(SfCalendar bindable)
        {
            base.OnDetachingFrom(bindable);

            if (this.sfCalendar != null)
            {
                this.sfCalendar.SelectionChanged -= SfCalendar_SelectionChanged;
            }

            this.sfCalendar = null;
        }
    }
}