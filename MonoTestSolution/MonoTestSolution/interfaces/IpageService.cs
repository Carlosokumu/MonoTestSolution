using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MonoTestSolution.interfaces
{
    public interface IpageService
    {
        Task PushAsync(Page page);
    }
}
