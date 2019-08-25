using Xamarin.Forms;

namespace XamarinMeetupIstanbul.Controls.Labels
{
    public class CaptionLabel : Label
    {
        public CaptionLabel()
        {
            FontSize = (OnPlatform<double>) Application.Current.Resources["Small"];
            TextColor = (Color)Application.Current.Resources["Red"];
        }
    }
}