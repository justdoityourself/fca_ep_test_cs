﻿using System;
using EchoPractice4Test.Framework;
using EchoPractice4Test.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EchoPractice4Test
{
    class Program
    {
        static void Main(string[] args)
        {
            State s = new State();
            Login l = new Login(s);

            l.Run();
        }
    }
}
