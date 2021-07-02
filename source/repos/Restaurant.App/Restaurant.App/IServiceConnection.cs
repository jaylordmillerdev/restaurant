namespace Restaurant.App
{
    public interface IService<T>
    {
        T Service { get; }
    }
}
