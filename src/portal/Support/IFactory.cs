namespace portal.Support
{
    public interface IFactory<in TIn, out TOut>
    {
        TOut Create(TIn input);
    }
}
