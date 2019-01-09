namespace portal.Support
{
    public interface IMapper<in TFrom, out TTo>
    {
        TTo Map(TFrom from);
    }
}
