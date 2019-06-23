﻿using System;
using System.Text;

namespace Device.Net.UnitTests
{
    internal class MockLogger : ILogger
    {
        StringBuilder _stringBuilder = new StringBuilder();

        public string LogText => _stringBuilder.ToString();

        public void Log(string message, string region, Exception ex, LogLevel logLevel)
        {
            _stringBuilder.Append(message);
        }
    }
}