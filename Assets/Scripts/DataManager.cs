using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
public List<PlayerData> records = new List<PlayerData>();
    void Awake() 
    {
        records.Add(new PlayerData("john", 5));
        records.Add(new PlayerData("Lola", 8));
        records.Add(new PlayerData("Hannah", 6));
        records.Add(new PlayerData("Mike", 7));
        records.Add(new PlayerData("Chad", 700));

    }
    public class PlayerData
    
    {
        public string name;
        public int score;
        public PlayerData (string Name, int Score)
        {
            name=Name;
            score=Score;
        }
    
    }
    [System.Serializable]
    class SaveData
    {


    }
}

