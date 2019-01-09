namespace portal.Services.Business
{
    using System;
    using portal.Models.Business;
    using portal.Models.Mappers;
    using portal.Services.Repository;

    public class TaskService : ITaskService
    {
        private readonly ITaskRepository taskRepository;
        private readonly ITaskMapper taskMapper;

        public TaskService(
            ITaskRepository taskRepository,
            ITaskMapper taskMapper)
        {
            this.taskRepository = taskRepository ?? throw new ArgumentNullException(nameof(taskRepository));
            this.taskMapper = taskMapper ?? throw new ArgumentNullException(nameof(taskMapper));
        }

        public Task Get(string id)
        {
            return this.taskMapper.Map(this.taskRepository.Get(id));
        }

        public Task Create(Task model)
        {
            return this.taskMapper.Map(this.taskRepository.Create(this.taskMapper.Map(model)));
        }

        public void Delete(string id)
        {
            this.taskRepository.Delete(id);
        }

        public Task Update(Task model)
        {
            return this.taskMapper.Map(this.taskRepository.Update(this.taskMapper.Map(model)));
        }
    }
}
