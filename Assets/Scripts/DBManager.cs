using System.Data;
using Mono.Data.Sqlite;
using UnityEngine;

public class DBManager : MonoBehaviour
{
    private static string dbName = "CR2.db";
    private string filepath = $"{Application.dataPath}/StreamingAssets/SQLite/{dbName}";

    private void Start()
    {
        DisplayPlayerDataTest();
    }
    
    //  DO THIS LATER PERCHANCE
    // public void CreateDB()
    // {
    //     using (var connection = new SqliteConnection(dbName))
    //     {
    //         
    //     }
    // }

    public void DisplayPlayerDataTest()
    {
        using (var connection = new SqliteConnection($"URI=file:{filepath}"))
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM PlayerStat";

                using (IDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Debug.Log($"Money: {reader[0]}, Food: {reader[1]}");
                    }
                    
                    reader.Close();
                }
            }
            
            connection.Close();
        }
    }
}
