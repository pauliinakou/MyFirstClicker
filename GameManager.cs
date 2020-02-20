using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private Text countText;
    private int count = 0;

    private void Start()
    {
        countText = GameObject.FindGameObjectWithTag("count").GetComponent<Text>();
        count = Session.ClickCount;
        UpdateCount();
    }

    public void AddToCount()
    {
        count++;
        UpdateCount();
    }

    private void UpdateCount()
    {
        countText.text = count.ToString();
    }

    private void DoQuit()
    {
        PlayerPrefs.SetInt("Count", count);
        Application.Quit();
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            DoQuit();
        }
    }
}
