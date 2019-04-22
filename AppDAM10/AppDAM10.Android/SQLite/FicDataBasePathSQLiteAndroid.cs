using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AppDAM10.Droid.SQLite;
using AppDAM10.Interfaces.SQLite;
using Xamarin.Forms;

[assembly:Dependency(typeof(FicDataBasePathSQLiteAndroid))]
namespace AppDAM10.Droid.SQLite
{
    class FicDataBasePathSQLiteAndroid :IFicDataBasePathSQLite
    {
        public string FicGetDataBasePath()
        {
            return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal),FicAppSettings.FicDataBaseName);
        }
    }
}