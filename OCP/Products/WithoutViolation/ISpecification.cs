namespace WithoutViolation
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }
}