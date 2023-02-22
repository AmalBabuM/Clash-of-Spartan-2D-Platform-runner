using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    private string saveFileName = "/savedata.json";
    
    public void SaveData(int score)
    {
        SaveDataObject data = new SaveDataObject();
        data.score = score;

        string jsonData = JsonUtility.ToJson(data);
        /*File.WriteAllText(Application.persistentDataPath + "/dangerfiles.json",jsonData);*/
        File.WriteAllText(Application.dataPath + saveFileName, jsonData);
        /*Debug.Log(Application.persistentDataPath);*/

    }   
    public SaveDataObject LoadGame()
    {

        string jsonData=File.ReadAllText(Application.dataPath+saveFileName);
        SaveDataObject obj= JsonUtility.FromJson<SaveDataObject>(jsonData);
        return obj;
    }
    /*[System.Serializable]*/
    public class SaveDataObject
    {
        public int score;
        public int health;
        public int scene;
    }
}
