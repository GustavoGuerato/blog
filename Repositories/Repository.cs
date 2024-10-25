using System.Collections;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class Repository<T> where T : class
    {
        private readonly SqlConnection _connection = new SqlConnection("");

        public Repository(SqlConnection connection)
        => _connection = connection;

        public IEnumerable<T> GetAll()
       => _connection.GetAll<T>();

        public T Get(int id, String connectionString)
             => _connection.Get<T>(id);
        public void Create(T model)
        =>
            _connection.Insert<T>(model);



        public void Update(T model)
        => _connection.Update<T>(model);

        public void Delete(T model)
        => _connection.Delete<T>(model);


        public void Delete(int id)
        {
            var model = _connection.Get<T>(id);
            _connection.Delete<T>(model);
        }

        public void UpdateById(int id, T model)
        {
            var existingEntity = _connection.Get<T>(id);

            if (existingEntity != null)
            {
                _connection.Update<T>(model);
                System.Console.WriteLine("Atualizacao realizada com sucesso");
            }
            else
            {
                System.Console.WriteLine("ocorreu algum erro");
            }
        }

        public void DeleteById(int id)
        {
            var entity = _connection.Get<T>(id);

            if (entity != null)
            {
                _connection.Delete<T>(entity);
                System.Console.WriteLine("exclusão com sucesso");
            }
            else
            {
                System.Console.WriteLine("ocorreu algum erro");
            }
        }



    }
}