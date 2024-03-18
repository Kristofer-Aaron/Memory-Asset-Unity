using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data.SQLite;
using System.IO;
using System;

public class DBCommands : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    private SQLiteConnection csatlakozas(){
        string assetsPath = Application.dataPath;
        string path = Path.Combine(assetsPath, "Adatbazisok/kartya.db");
        string connectionString = "Data Source="+path+";Version=3;";
        return new SQLiteConnection(connectionString);
    }
    public byte[] keplekerd(string sqlkerd){
            SQLiteConnection connection = csatlakozas();
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(sqlkerd, connection);
            byte[] imageData = (byte[])command.ExecuteScalar();
            connection.Close();
            return imageData;
    }
    //public void kepfeltolt(){
    //}
}
