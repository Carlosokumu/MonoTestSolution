using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Autofac;
using MonoTestSolution.BootStrap;
using MonoTestSolution.Droid.memory;
using MonoTestSolution.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoTestSolution.Droid
{
    public class BaseClass: Application
    {

        public BaseClass() { }
        public override void OnCreate()
        {
            base.OnCreate();
           // Log.Debug("AppInit","Application Started");
            //var sqliteConnection = new SQLiteDb().GetConnection();
            //var respository = AppContainer.Container.Resolve<RepositoryDataSource>();
           // respository.InitializeDb();


        }
    }
}