using Xamarin.Forms;

namespace XamarinMeetupIstanbul.Controls.Buttons
{
    public class PrimaryButton : Button
    {
        public PrimaryButton()
        {
            BackgroundColor = (Color)Application.Current.Resources["Black"];
            TextColor = (Color) Application.Current.Resources["Red"];
            BorderColor = (Color) Application.Current.Resources["White"];
            FontFamily = (OnPlatform<string>) Application.Current.Resources["SourceSansPro-Regular"];
        }
    }
}