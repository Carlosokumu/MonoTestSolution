using MonoTestSolution.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MonoTestSolution
{
    public class PageService : IpageService
    {
        public async Task PushAsync(Page page)
        {
            await MainPage.Navigation.PushAsync(page);
        }
       private Page MainPage
        {
            get { return Application.Current.MainPage; }
        }
    }
}
