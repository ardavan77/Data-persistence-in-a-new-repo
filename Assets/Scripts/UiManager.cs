using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public List<TextMeshProUGUI> nameScoresGui = new List<TextMeshProUGUI>();
    public List<TextMeshProUGUI> numberScoresGui = new List<TextMeshProUGUI>();
    public Button startButton;
    public Text topScore;
    // Start is called before the first frame update
    void Start()
    {
        DataManager.Instance.LoadData();
        if (DataManager.Instance.records != null && SceneManager.GetActiveScene().buildIndex == 0)
        {
            List<DataManager.PlayerData> sortedRecords = DataManager.Instance.records.OrderByDescending(s => s.score).ToList();
            for (int i = 0; i < sortedRecords.Count; i++)
            {
                nameScoresGui[i].text = sortedRecords[i].name;
                numberScoresGui[i].text = sortedRecords[i].score.ToString();

            }
        }
        else if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            List<DataManager.PlayerData> sortedRecords = DataManager.Instance.records.OrderByDescending(s => s.score).ToList();
            topScore.text = $"Top Score: {sortedRecords[0].name} : {sortedRecords[0].score}";
        }




    }

    // Update is called once per frame
    void Update()
    {


    }
    public void StartMainScene()
    {
        SceneManager.LoadScene(1);
    }
    public void EnableButton()
    {
        if (!string.IsNullOrEmpty(DataManager.Instance.currentPlayerName))
        {
            startButton.interactable = true;
        }
    }
}

