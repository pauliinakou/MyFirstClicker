using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private GameObject continueButton;

    void Start()
    {
        continueButton = GameObject.Find("ContinueButton"); //.GetComponent<Button>();

        Session.ClickCount = PlayerPrefs.GetInt("Count", 0);

        if(Session.ClickCount == 0)
        {
            continueButton.SetActive(false);
            //continueButton.interactable = false;
        }
        else
        {
            continueButton.SetActive(true);
            //continueButton.interactable = true;
        }
    }

    public void OnClick_ContinueButton()
    {
        SceneManager.LoadScene(1);
    }

    public void OnClick_NewButton()
    {
        Session.ClickCount = 0;
        SceneManager.LoadScene(1);
    }

    public void OnClick_QuitButton()
    {
        Application.Quit();
    }
}
