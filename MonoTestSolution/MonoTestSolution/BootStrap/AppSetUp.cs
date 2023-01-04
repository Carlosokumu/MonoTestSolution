using System;
using Xamarin.Forms;
using MonoTestSolution.memory;

namespace MonoTestSolution.BootStrap
{
    public  class AppSetUp
    {
     
       
        public static ISQLiteDb GetApplicationRuntimeSettings()
        {
            var platformSpecificSettings = DependencyService.Get<ISQLiteDb>();
            if (platformSpecificSettings == null)
            {
                throw new InvalidOperationException($"Missing '{typeof(ISQLiteDb).FullName}' implementation! Implementation is required.");
            }
            return platformSpecificSettings;
        }
    }
}
