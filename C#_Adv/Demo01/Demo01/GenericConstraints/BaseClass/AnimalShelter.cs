using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01.GenericConstraints.BaseClass
{
    internal class AnimalShelter<T> where T : Animal
    {
        List<T> animals = new List<T>();

        public void AddAnimal(T animal)
        {
            animals.Add(animal);
        }

        public void LoopAnimals()
        {
            foreach (var animal in animals)
                Console.WriteLine($"{animal.Name} {animal.Speak()}");
                
            
        }
    }
}
