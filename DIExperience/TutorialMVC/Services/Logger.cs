﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialMVC.Services
{
    public interface ILogger
    {
        void Log(string message);
    }
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Debug.WriteLine($"寫入日誌中 : {message}");
        }
    }
}
