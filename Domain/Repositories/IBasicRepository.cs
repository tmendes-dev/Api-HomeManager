namespace Domain.Repositories
{
    public interface IBasicRepository<T>
    {
        int Create(T entity);

        T Retrieve(int id);

        T Update(T entity);

        void Delete(T entity);
    }
}