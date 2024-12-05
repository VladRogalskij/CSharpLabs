using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    class TaskController
    {
        private readonly List<ITask> _tasks;

        public TaskController()
        {
            _tasks = new List<ITask>();
        }

        public void AddTask(ITask task)
        {
            _tasks.Add(task);
        }

        public void ExecuteAll()
        {
            foreach (var task in _tasks)
            {
                task.TaskX();
            }
        }
    }
}
