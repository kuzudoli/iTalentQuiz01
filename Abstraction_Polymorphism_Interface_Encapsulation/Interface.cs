using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Polymorphism_Interface_Encapsulation
{
    //We're creating interface like contract for classes.
    //If they're implementing this interface (contract) they must fill the body.
    //If we need new classes we can just implement the interface...
    //...without update the exist codes and write our new methods.
    public interface IRepository
    {
        void Create();
        void Update();
        void Read();
        void Delete();
    }

    public class SQLRepository : IRepository
    {
        public void Create()
        {
            Console.WriteLine("Created on SQL!");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted on SQL!");
        }

        public void Read()
        {
            Console.WriteLine("Read from SQL!");
        }

        public void Update()
        {
            Console.WriteLine("Updated on SQL!");
        }
    }

    public class MongoDBRepository : IRepository
    {
        public void Create()
        {
            Console.WriteLine("Created on MongoDB!");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted on MongoDB!");
        }

        public void Read()
        {
            Console.WriteLine("Read from MongoDB!");
        }

        public void Update()
        {
            Console.WriteLine("Updated on MongoDB!");
        }
    }

    public class BLL
    {
        IRepository _repository;

        public BLL(IRepository repository)
        {
            _repository = repository;
        }

        public void Create()
        {
            _repository.Create();
        }

        public void Delete()
        {
            _repository.Delete();
        }

        public void Read()
        {
            _repository.Read();
        }

        public void Update()
        {
            _repository.Update();
        }
    }
}
