using System;
using System.Collections.Generic;
using System.Text;
using AppDAM10.Models;

namespace AppDAM10
{
    public class FicAppSettings
    {
        public static string FicDataBaseName = "DB_INVENTARIOS.db3";
        public static string FicUrlBase { get => "http://localhost:60304/"; set { } }
    }
}
