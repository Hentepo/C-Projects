﻿using ATMApplicationAlternative2.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApplicationAlternative2.App
{
    class Entry
    {
        static void Main(string[] args)
        {
            ATMApp atmApp = new ATMApp();
            atmApp.InitializedData();
            atmApp.Run();
        }
    }
}