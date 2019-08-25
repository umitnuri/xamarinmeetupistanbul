using Xamarin.Forms;

namespace XamarinMeetupIstanbul.Controls.Labels
{
    public class TitleLabel : Label
    {
        public TitleLabel()
        {
            FontSize= (OnPlatform<double>)Application.Current.Resources["Huge"];
            FontFamily = (OnPlatform<string>)Application.Current.Resources["SourceSansPro-Bold"];
        }
    }
}