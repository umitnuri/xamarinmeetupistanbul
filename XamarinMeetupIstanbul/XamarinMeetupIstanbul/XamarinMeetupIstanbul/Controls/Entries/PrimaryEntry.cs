using Xamarin.Forms;

namespace XamarinMeetupIstanbul.Controls.Entries
{
    public class PrimaryEntry : Entry
    {
        public PrimaryEntry()
        {
            BackgroundColor = (Color)Application.Current.Resources["Black"];
            TextColor = (Color) Application.Current.Resources["White"];
            FontSize = (OnPlatform<double>) Application.Current.Resources["Large"];
            HeightRequest = 40;
        }
    }
}