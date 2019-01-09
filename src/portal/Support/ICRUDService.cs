namespace portal.Support
{
    public interface ICRUDService<T>
    {
        T Get(string id);

        T Create(T model);

        void Delete(string id);

        T Update(T model);
    }
}
