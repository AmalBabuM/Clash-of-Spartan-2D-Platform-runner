using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public static class SaveSystem
{
    private static string saveFileName = "/Amaldata.json";
    
    public static void SavePlayer(Player player)
    {
        PlayerData data = new PlayerData(player);

        string jsonData = JsonUtility.ToJson(data);
        File.WriteAllText(Application.dataPath + saveFileName, jsonData);

    }

    public static PlayerData LoadPlayer()
    {
        string jsonData = File.ReadAllText(Application.dataPath + saveFileName);
        if(File.Exists(jsonData))
        {
            PlayerData data = JsonUtility.FromJson<PlayerData>(jsonData);
            return data;
        }
        else
        {
            Debug.Log("File not found");
            return null;
        }
    }

  /*  public void SaveData(int score)
    {
        SaveDataObject data = new SaveDataObject();
        data.score = score;

        string jsonData = JsonUtility.ToJson(data);
        *//*1 File.WriteAllText(Application.persistentDataPath + "/dangerfiles.json",jsonData);*//*
        File.WriteAllText(Application.dataPath + saveFileName, jsonData);
         *//*2 Debug.Log(Application.persistentDataPath);*//*

    }   */



   /* public SaveDataObject LoadGame()
    {

        string jsonData=File.ReadAllText(Application.dataPath+saveFileName);
        SaveDataObject obj= JsonUtility.FromJson<SaveDataObject>(jsonData);
        return obj;
    }*/
    
}
