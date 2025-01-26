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

    public int InitializeMoney()
    {
        int money = 0;
        
        using (var connection = new SqliteConnection($"URI=file:{filepath}"))
        {
            connection.Open();
            
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT Money FROM PlayerStat";
                
                using (IDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        money = int.Parse(reader[0].ToString());
                    }
                    
                    reader.Close();
                }
            }
            
            connection.Close();
        }
        
        return money;
    }

    public void GetMoney(int amount)
    {
        using (var connection = new SqliteConnection($"URI=file:{filepath}"))
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = $"UPDATE PlayerStat SET Money = Money + {amount}";
            }

            connection.Close();
        }
    }
}
