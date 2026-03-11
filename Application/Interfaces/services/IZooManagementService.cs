using Domain;

namespace Application;

public interface IZooManagementService
{
    Task Add(Zoo animal);
    Task Remove(int id);
    Task<List<Zoo>> GetAll();
}