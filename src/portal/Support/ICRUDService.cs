namespace portal.Support
{
    public interface ICRUDService<T>
    {
        T Get(string id);

        T Create(T model);

        T Delete(string id);

        T Update(T model);
    }
}
