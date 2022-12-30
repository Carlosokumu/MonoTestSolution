using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoTestSolution.BootStrap
{
    public static class AppContainer
    {

        public static IContainer Container { get; set; }
        public static String ConnectionPath { get; set; }
    }
}
