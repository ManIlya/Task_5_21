using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Task_5_21;

namespace Task_5_21
{
    internal class InstrumentController
    {
        public IMusicalInstrument instrument { get; set; }


        public static List<string> GetInstrumentClassNames(string assemblyPath)
        {
            Assembly assembly = Assembly.LoadFrom(assemblyPath);
            Type interfaceType = typeof(IMusicalInstrument);

            List<string> classNames = new List<string>();

            foreach (Type type in assembly.GetTypes())
            {
                if (interfaceType.IsAssignableFrom(type))
                {
                    classNames.Add(type.FullName);
                }
            }

            return classNames;
        }   

    }
}
