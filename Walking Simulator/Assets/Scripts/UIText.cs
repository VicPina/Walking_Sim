using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIText : MonoBehaviour
{
    private Text nameDisplayer;

    private string nameToShow;
    // Start is called before the first frame update
    public void Start()
    {
        nameDisplayer = GetComponent<Text>();
    }

    // Update is called once per frame
    public void DisplayName(string name)
    {
        nameToShow = name;
        nameDisplayer.text = nameToShow;
    }
}
