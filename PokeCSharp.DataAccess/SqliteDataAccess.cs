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

    public static List<PokemonMoveModel> GetAllPokemonsMoves()
    {
        string connectionString = LoadConnectionString();
        IDbConnection connection = new SQLiteConnection(connectionString);

        try
        {
            connection.Open();


            List<PokemonMoveModel> pokemonMoves = connection
                .Query<PokemonMoveModel>("SELECT PokemonMoveId, PokemonMoveIdentifier FROM PokemonMove")
                .ToList();

            return pokemonMoves;
        }
        finally
        {
            connection.Dispose();
        }
    }

    public static List<PokemonTypeModel> GetAllPokemonTypes()
    {
        string connectionString = LoadConnectionString();
        IDbConnection connection = new SQLiteConnection(connectionString);

        try
        {
            connection.Open();


            List<PokemonTypeModel> pokemonTypes = connection
                .Query<PokemonTypeModel>("SELECT PokemonTypeId, PokemonTypeIdentifier FROM PokemonType")
                .ToList();

            return pokemonTypes;
        }
        finally
        {
            connection.Dispose();
        }
    }


    public static List<GameModel> GetAllGames()
    {
        string connectionString = LoadConnectionString();
        IDbConnection connection = new SQLiteConnection(connectionString);

        try
        {
            connection.Open();


            List<GameModel> games = connection
                .Query<GameModel>("SELECT GameId, GameName FROM Game")
                .ToList();

            return games;
        }
        finally
        {
            connection.Dispose();
        }
    }


    public static List<ItemModel> GetAllItems()
    {
        string connectionString = LoadConnectionString();
        IDbConnection connection = new SQLiteConnection(connectionString);

        try
        {
            connection.Open();


            List<ItemModel> items = connection
                .Query<ItemModel>("SELECT ItemId, ItemIdentifier FROM Item")
                .ToList();

            return items;
        }
        finally
        {
            connection.Dispose();
        }
    }

    public static List<RegionModel> GetAllRegions()
    {
        string connectionString = LoadConnectionString();
        IDbConnection connection = new SQLiteConnection(connectionString);

        try
        {
            connection.Open();


            List<RegionModel> regions = connection
                .Query<RegionModel>("SELECT RegionId, RegionName FROM Region")
                .ToList();

            return regions;
        }
        finally
        {
            connection.Dispose();
        }
    }
    public static List<LocationModel> GetAllLocations()
    {
        string connectionString = LoadConnectionString();
        IDbConnection connection = new SQLiteConnection(connectionString);

        try
        {
            connection.Open();


            List<LocationModel> locations = connection
                .Query<LocationModel>("SELECT LocationId, LocationName FROM Location")
                .ToList();

            return locations;
        }
        finally
        {
            connection.Dispose();
        }
    }














}





