using MongoDB.Driver;
using System;

namespace Api_Crud.Models
{
    public class MongoDbContext
    {
        public static string ConnectionString { get; set; }
        public static string DatabaseName { get; set; }
        public static bool IsSSL { get; set; }

        private IMongoDatabase _database { get; }

        public MongoDbContext()
        {
            try
            {
                MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(ConnectionString));
                if (IsSSL)
                {
                    settings.SslSettings = new SslSettings
                    {
                        EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12
                    };
                }
                var mongoClient = new MongoClient(settings);
                _database = mongoClient.GetDatabase(DatabaseName);
            }
            catch (Exception e)
            {
                throw new Exception("Não foi possivel se conectar com o servidor.", e);
            }
        }
        public IMongoCollection<Registros> Registro
        {
            get
            {
                return _database.GetCollection<Registros>("Registros");
            }
        }
    }
}
