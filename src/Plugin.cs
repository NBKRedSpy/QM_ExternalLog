using MGSC;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityExternalLogWindow;

namespace QM_ExternalLog
{
    public static class Plugin
    {
        public static string ModAssemblyName => Assembly.GetExecutingAssembly().GetName().Name;


        [Hook(ModHookType.BeforeBootstrap)]
        public static void BeforeBootstrap(IModContext context)
        {
            Debug.unityLogger.logHandler = new ColoredLog();
        }
    }
}
