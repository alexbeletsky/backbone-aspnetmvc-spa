using System.Collections.Generic;
using System.Web.Http;
using Spa.Models;
using Spa.Models.Repositories;

namespace Spa.Api
{
    public class TasksController : ApiController
    {
        private TasksRepository _tasksRepository;

        public TasksController()
        {
            _tasksRepository = new TasksRepository();
        }

        public IEnumerable<Task> GetTasks()
        {
            return _tasksRepository.All;
        }
    }
}
