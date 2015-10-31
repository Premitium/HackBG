using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager
{
    class Program
    {
        public static void Main()
        {
            List<string> installed = new List<string>();
            //read the all packages file and create an PackageJSON
            PackageJSON allPackages = ReadObjectAllPackages();
            //read the dependencies file and create an instance of DependencyJSON
            DependencyJSON dependencies = ReadObjectDependencies();
            CheckDependencies(allPackages, dependencies, installed);
        }

        public class PackageJSON
        {
            public string[] backbone;
            public string[] jQuery;
            public string[] underscore;
            public string[] queryJ;
            public string[] lodash;
        }
        public class DependencyJSON
        {
            public string projectName;
            public string[] dependencies;
        }
        public static void CheckDependencies(PackageJSON allPackages, DependencyJSON dependencies, List<string> installed)
        {
            for (int i = 0; i < dependencies.dependencies.Length; i++)
            {
                if (dependencies.dependencies[i] == "backbone")
                {
                    if (installed.Contains("backbone"))
                    {
                        Console.WriteLine("Backbone is already installed");
                    }
                    else
                    {
                        Console.WriteLine("Installing backbone");
                        Console.WriteLine("In order to install backbone, we need jQuery and underscore");
                        CreateFile("backbone");
                        installed.Add("backbone");
                        installed.Add("jQuery");
                        installed.Add("underscore");
                        for (int b = 0; b < allPackages.backbone.Length; b++)
                        {
                            CreateFile(allPackages.backbone[b]);
                        }
                    }
                }

                if (dependencies.dependencies[i] == "jQuery")
                {

                    if (installed.Contains("jQuery"))
                    {
                        Console.WriteLine("jQuery is already installed");
                    }
                    else
                    {
                        Console.WriteLine("Installing jQuery");
                        Console.WriteLine("In order to install jQuery, we need queryJ");

                        for (int b = 0; b < allPackages.jQuery.Length; b++)
                        {
                            CreateFile(allPackages.jQuery[b]);
                        }
                    }
                }

                if (dependencies.dependencies[i] == "underscore")
                {
                    Console.WriteLine("Installing _underscore");
                    Console.WriteLine("In order to install _underscore  , we need lodash");

                    for (int b = 0; b < allPackages.underscore.Length; b++)
                    {
                        CreateFile(allPackages.underscore[b]);
                    }
                }
            }
        }
        public static void AddjQuery() {

        }
        public static void CreateFile(string folder)
        {
            // Specify the directory you want to manipulate.
            string path = @"C:\Users\Simo\Documents\Visual Studio 2015\Projects\Third application problem\PackageManager\dependencies\installed_modules\";
            path += folder;

            try
            {
                Console.WriteLine("Installing " + folder);
                // Determine whether the directory exists.
                if (Directory.Exists(path))
                {
                    Console.WriteLine("{0} exists already.", folder);
                    return;
                }

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(path);
                Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));

                // Delete the directory.
                //di.Delete();
                //Console.WriteLine("The directory was deleted successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }
        }
        public static PackageJSON ReadObjectAllPackages()
        {
            string json = File.ReadAllText(@"C:\Users\Simo\Documents\Visual Studio 2015\Projects\Third application problem\PackageManager\dependencies\all_packages.json");
            PackageJSON newObject = JsonConvert.DeserializeObject<PackageJSON>(json);
            return newObject;
        }

        public static DependencyJSON ReadObjectDependencies()
        {
            string json = File.ReadAllText(@"C:\Users\Simo\Documents\Visual Studio 2015\Projects\Third application problem\PackageManager\dependencies\dependencies.json");
            DependencyJSON newObject = JsonConvert.DeserializeObject<DependencyJSON>(json);
            return newObject;
        }
    }
}
