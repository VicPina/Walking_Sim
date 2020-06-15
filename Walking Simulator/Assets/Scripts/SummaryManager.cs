using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SummaryManager : MonoBehaviour
{
    private Text summaryText;
    private Text completedText;

    public List<string> objectsToCollect = new List<string>();
    public List<string> objectsCollected = new List<string>();

    private void Awake() 
    {
        summaryText = GetComponent<Text>();
        completedText = transform.GetChild(0).GetComponent<Text>();
    }
    
    private void Start() { ShowSummary(); }

    public void ShowSummary()
    {
        summaryText.text += "Tasks to be done: \n";
        for(int i=0; i<objectsToCollect.Count; ++i)
        {
            summaryText.text += objectsToCollect[i] + "\n";
        }
        completedText.text += "Tasks completed: \n";
        for (int i = 0; i < objectsCollected.Count; ++i)
        {
            completedText.text += objectsCollected[i] + "\n";
        }/*
        foreach(string item in testing)
        {
            summaryText.text += item.ToString();
        }
        */
    }
}
