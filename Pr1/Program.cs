using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var taskController = new TaskController();

            taskController.AddTask(new Task1());
            taskController.AddTask(new Task2());
            taskController.AddTask(new Task3());
            taskController.AddTask(new Task4());

            taskController.ExecuteAll();

        }
    }
}
