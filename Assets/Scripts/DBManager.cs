using System.Data;
using Mono.Data.Sqlite;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class DBManager : MonoBehaviour
{
    private static string dbName = "ChickenRaptor.db";
    private string filepath = $"{Application.dataPath}/StreamingAssets/SQLite/{dbName}";

    private void Start()
    {
        InitializePlayer();
    }
    
    //  DO THIS LATER PERCHANCE
    // public void CreateDB()
    // {
    //     using (var connection = new SqliteConnection(dbName))
    //     {
    //         
    //     }
    // }
    
    public void InitializePlayer()
    {
        using (var connection = new SqliteConnection($"URI=file:{filepath}"))
        {
            connection.Open();
            
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM PlayerStat; VACUUM";
                
                command.ExecuteNonQuery();
                
                command.CommandText = "INSERT INTO PlayerStat (Money) VALUES (100)";
                
                command.ExecuteNonQuery();

                command.CommandText = "SELECT Money FROM PlayerStat";
                
                using (IDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Debug.Log($"Money: {reader[0]}");
                    }
                    
                    reader.Close();
                }
            }
            
            connection.Close();
        }
    }
}
