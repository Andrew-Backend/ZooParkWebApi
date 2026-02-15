using Domain;

namespace Aplication;

public interface IManagementService
{
    void AddAnimal(string name,TypeAnimalEnum type, int age);
    void RemoveAnimal(string name);
}