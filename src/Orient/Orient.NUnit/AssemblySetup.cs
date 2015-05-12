using System;
using System.IO;
using NUnit.Framework;
using System.Reflection;

namespace Orient.Tests
{
    [SetUpFixture]
    public class AssemblySetup
    {

        private static string _orientServerDirectory = @"..\..\..\..\..\db\orientdb-community-2.1-rc2";
        //private static string _orientServerDirectory = @"..\..\..\..\..\db\orientdb-enterprise-2.0.3";

        [SetUp]
        public static void Setup()
        {
          
            // orientDbDir needs to point to the path of an OrientDB installation (pointing to the folder that contains the bin, lib, config sub folders)
            var orientDBDir = Path.GetFullPath(Path.Combine( AppDomain.CurrentDomain.BaseDirectory, _orientServerDirectory));
            //var orientDBDir = @"C:/lang/orientdb-enterprise-2.0.3";
            // jreDir needs to point to a JRE (or JDK)
            var jreDir = @"C:\Program Files\Java\jre7";
            DbRunner.StartOrientDb(orientDBDir, jreDir);
        }

        [TearDown]
        public static void TearDown()
        {
            DbRunner.StopOrientDb(_orientServerDirectory);
        }
    }
}
