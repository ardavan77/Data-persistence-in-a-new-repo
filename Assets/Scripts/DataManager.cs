using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    public List<PlayerData> records = new List<PlayerData>();
    public string currentPlayerName;
    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        Instance = this;


    }
    [System.Serializable]
    public class PlayerData

    {
        public string name;
        public int score;
        public PlayerData(string Name, int Score)
        {
            name = Name;
            score = Score;
        }

    }
    [System.Serializable]
    class SaveData
    {
        public List<PlayerData> records;
    }
    public void CreateSave()
    {
        SaveData data = new SaveData();
        data.records = records;
        string json = JsonUtility.ToJson(data);
        Debug.Log(json);
        File.WriteAllText(Application.persistentDataPath + "/savefile.Json", json);

    }
    public void LoadData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            records = data.records;

        }
    }
    public void StoreCurrentPlayer(String inputName)
    {
        currentPlayerName = inputName;
        Debug.Log(currentPlayerName);
    }
    public void StoreCurrentPlayer(string inputName, int currentscore)
    {
        PlayerData player = new PlayerData(inputName, currentscore);
        records.Add(player);
        CreateSave();
    }
}

