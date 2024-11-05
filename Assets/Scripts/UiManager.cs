using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    
    public DataManager dataManager;
     
   public List <TextMeshProUGUI> nameScoresGui=new List<TextMeshProUGUI>();
   public List <TextMeshProUGUI> numberScoresGui=new List<TextMeshProUGUI>();
    // Start is called before the first frame update
    void Start()
    {
        List <DataManager.PlayerData> sortedRecords = dataManager.records.OrderByDescending(s=>s.score).ToList();
        for (int i = 0; i < sortedRecords.Count; i++)
        {
            nameScoresGui[i].text=sortedRecords[i].name;
            numberScoresGui[i].text=sortedRecords[i].score.ToString();
        }
    
    }

    // Update is called once per frame
    void Update()
    {

    }
}

