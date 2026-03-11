using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;

namespace Application;

public interface IManagementService <T>
{
    Task Add(T entity);
    Task Remove(int id);
    Task<List<T>> GetAll();
}