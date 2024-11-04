using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class DataManager : MonoBehaviour
{
    
   
   class RecordData
   {
    public string Name;
    public int Score;
   public RecordData (string name, int score)
   {
    Name= name;
    Score = score;
   }
   }
[System.Serializable]
class SaveData
{
    public List<RecordData> records;

}
}

