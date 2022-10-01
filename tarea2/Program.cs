using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2
{
    internal class Program
    {
        public static void aguinaldo(String [] empleado,float[]salario)
        {
            float calcaguinaldo = 0;
            
            for (int i = 0; i < empleado.Length; i++)
            {
                calcaguinaldo = salario[i] * 12;
                Console.WriteLine("Empleado: "+empleado[i] +" Salario: "+salario[i]+" Aguinaldo: " + calcaguinaldo);
            }
           
        }
        static void Main(string[] args)
        {
            String[] empleado = { "Juan", "Maria", "Eduardo", "Adrian", "Ana" };
            float [] salario = { 2000, 5400, 3200, 4150, 2750 };
            aguinaldo(empleado, salario);
            Console.Read();

        }
    }
}
