using Xamarin.Forms;

namespace XamarinMeetupIstanbul.Controls.Buttons
{
    public class SecondaryButton : Button
    {
        public SecondaryButton()
        {
            BackgroundColor = (Color)Application.Current.Resources["Grey"];
            TextColor = (Color)Application.Current.Resources["Black"];
            BorderColor = (Color)Application.Current.Resources["White"];
            FontFamily = (OnPlatform<string>)Application.Current.Resources["SourceSansPro-Regular"];
        }
    }
}