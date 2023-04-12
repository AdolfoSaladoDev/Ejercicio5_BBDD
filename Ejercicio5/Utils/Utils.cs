using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Utils
{
    static class Utils
    {
        public static int CreateRandomId()
        {
            return new Random().Next(1, 1000);
        }

        public static string CheckName(string name)
        {
            return string.IsNullOrEmpty(name) ? "Nuevo" : name;
        }
    }
}
