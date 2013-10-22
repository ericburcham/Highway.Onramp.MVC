// [[Highway.Onramp.MVC.Data]]
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;
using Templates.App_Architecture.Data;

[assembly: WebActivatorEx.PostApplicationStartMethod(
    typeof(Templates.App_Architecture.Activators.DatabaseInitializerActivator), 
    "PostStartup")]
namespace Templates.App_Architecture.Activators
{
    public static class DatabaseInitializerActivator
    {
        public static void PostStartup()
        {
#pragma warning disable 618
            var initializer = IoC.Container.Resolve<IDatabaseInitializer<HighwayDataContext>>();
#pragma warning restore 618
            Database.SetInitializer(initializer);
        }
    }
}