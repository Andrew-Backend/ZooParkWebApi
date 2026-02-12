using Domain;

namespace Aplication;

public interface IManagementService
{
    void AddAnimal(string name,TypeAnimal type, int age);
    void RemoveAnimal(string name);
}