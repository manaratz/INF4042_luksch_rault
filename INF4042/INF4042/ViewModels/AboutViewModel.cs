using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace INF4042
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            EmailFred = new Command(() => Device.OpenUri(new Uri("mailto:luksch@et.esiea.fr")));
            EmailVal = new Command(() => Device.OpenUri(new Uri("mailto:luksch@et.esiea.fr")));


        }

        public ICommand EmailFred { get; }
        public ICommand EmailVal { get; }

    }
}