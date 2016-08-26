using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace FakeItTillYouMakeIt.Examples
{
    public class FakeItCounter
    {
        public const string file = "fakeit.counter.txt";

        public static void Increment()
        {
            long count = 0;
            if (File.Exists(file))
            {
                Int64.TryParse(File.ReadAllText(file), out count);
            }
            count++;
            File.WriteAllText(file, "" + count);
        }

        public static void Reset()
        {
            if (File.Exists(file))
            {
                File.Delete(file);
            }
        }

        public static void ResetAndLaunch()
        {
            Reset();
            Launch();
        }

        private static void Launch()
        {
            var java = @"C:\ProgramData\Oracle\Java\javapath\javaw.exe";
            var jar = @"C:\code\FakeItTillYouMakeIt.Examples\CounterDisplay.jar";
            Task.Factory.StartNew(
                () => LaunchProgram(java, @"-jar "+ jar +" " + Path.GetFullPath(file)));
        }


        private static void LaunchProgram(string program, string arguments)
        {
            try
            {
                Console.WriteLine("Starting: "+ program + " " + arguments);
                Process.Start(program, arguments);
            }
            catch (Win32Exception e)
            {
                throw new Exception(
                   String.Format("Unable to launch: {0} with arguments {1}\nError Message: {2}",
                        program,
                        arguments,
                        e.Message),
                    e);
            }
        }
    }
}