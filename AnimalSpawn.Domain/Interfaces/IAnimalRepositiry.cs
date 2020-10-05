using AnimalSpawn.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSpawn.Infraestructure.Repositories
{
    public interface IAnimalRepositiry
    {
        Task<IEnumerable<Animal>> GetAnimals();
        Task<Animal> GetAnimal(int id);

    }
}
