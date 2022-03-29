using Dapper;
using PokeCSharp.Models;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace PokeCSharp.DataAccess;

public static class SqliteDataAccess
{
    private static string LoadConnectionString(string id="Default")
    {
        return ConfigurationManager.ConnectionStrings[id].ConnectionString;
    }
    public static List <PokemonModel> LoadPokemons()
    {
        string connectionString = LoadConnectionString();
        IDbConnection connection = new SQLiteConnection(connectionString);

        try
        {
            connection.Open();
           

            List<PokemonModel> pokemons = connection
                .Query<PokemonModel>("SELECT PokemonId,PokemonName, Height,Weight,BaseExperience,[Order], IsDefault FROM Pokemon")
                .ToList();

            return pokemons;
        }
        finally
        {
            connection.Dispose();
        }
    }
}
