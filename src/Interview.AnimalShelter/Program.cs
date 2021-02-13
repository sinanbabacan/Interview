using System;
using System.Collections.Generic;

namespace Interview.AnimalShelter
{
    class Program
    {


        static void Main(string[] args)
        {
            Shelter shelter = new Shelter();

            shelter.Enqueue(new Animal() { Type = AnimalType.Cat, JoinDate = DateTime.Now.AddDays(-1) });
            shelter.Enqueue(new Animal() { Type = AnimalType.Cat, JoinDate = DateTime.Now.AddDays(-2) });
            shelter.Enqueue(new Animal() { Type = AnimalType.Cat, JoinDate = DateTime.Now.AddDays(-3) });
            shelter.Enqueue(new Animal() { Type = AnimalType.Dog, JoinDate = DateTime.Now.AddDays(-4) });
            shelter.Enqueue(new Animal() { Type = AnimalType.Cat, JoinDate = DateTime.Now.AddDays(-5) });
            shelter.Enqueue(new Animal() { Type = AnimalType.Cat, JoinDate = DateTime.Now.AddDays(-6) });
            shelter.Enqueue(new Animal() { Type = AnimalType.Dog, JoinDate = DateTime.Now.AddDays(-7) });


            Animal animal = shelter.Dequeue(AnimalType.Dog);
            Animal animal2 = shelter.Dequeue(AnimalType.Dog);
            Animal animal3 = shelter.Dequeue(AnimalType.Dog);

        }

        public enum AnimalType
        {
            Cat,
            Dog
        }

        public class Animal
        {
            public DateTime JoinDate { get; set; }
            public AnimalType Type { get; set; }
        }

        public class Shelter
        {
            LinkedList<Animal> _shelter;

            public Shelter()
            {
                _shelter = new LinkedList<Animal>();
            }

            public void Enqueue(Animal animal)
            {
                _shelter.AddLast(animal);
            }

            public Animal DequeueAny()
            {
                if (_shelter.Count > 0)
                {
                    Animal value = _shelter.First.Value;

                    _shelter.RemoveFirst();

                    return value;
                }

                return null;
            }

            public Animal Dequeue(AnimalType type)
            {
                LinkedListNode<Animal> node = null;

                if (_shelter.Count > 0)
                {
                    node = _shelter.First;

                    while (node != null)
                    {
                        if (node.Value.Type == type)
                        {
                            _shelter.Remove(node);

                            break;
                        }

                        node = node.Next;
                    }
                }

                return node?.Value;
            }
        }
    }
}
