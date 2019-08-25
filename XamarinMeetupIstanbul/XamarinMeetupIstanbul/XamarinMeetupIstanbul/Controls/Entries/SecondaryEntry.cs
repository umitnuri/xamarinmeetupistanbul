using Xamarin.Forms;

namespace XamarinMeetupIstanbul.Controls.Entries
{
    public class SecondaryEntry : Entry
    {
        public SecondaryEntry()
        {
            BackgroundColor = (Color)Application.Current.Resources["Grey"];
            TextColor = (Color)Application.Current.Resources["Black"];
            FontSize = (OnPlatform<double>)Application.Current.Resources["Large"];
            HeightRequest = 40;
        }
    }
}