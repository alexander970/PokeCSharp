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
    public static List <PokemonModel> GetAllPokemons()
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

    public static PokemonModel SearchPokemon(string pokemonName)
    {
        string connectionString = LoadConnectionString();
        IDbConnection connection = new SQLiteConnection(connectionString);

        try
        {
            connection.Open();


            PokemonModel? pokemon = connection
                .QuerySingleOrDefault<PokemonModel>("SELECT PokemonId,PokemonName, Height,Weight,BaseExperience,[Order], IsDefault FROM Pokemon WHERE pokemonName = @pokemonName"
                ,new {pokemonName = pokemonName});
                

            return pokemon;
        }
        finally
        {
            connection.Dispose();
        }
    }







}


    


