using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WebApp
{
    public static class dbConnection
    {
       public static string connectionstring = ConfigurationManager.AppSettings["icraConnectionString"].ToString();
    }
}