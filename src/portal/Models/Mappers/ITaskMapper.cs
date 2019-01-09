namespace portal.Models.Mappers
{
    using portal.Support;
    using BusinessModel = Business.Task;
    using RepositoryModel = Repository.Task;

    public interface ITaskMapper : IMapper<RepositoryModel, BusinessModel>, IMapper<BusinessModel, RepositoryModel>
    {
    }
}
