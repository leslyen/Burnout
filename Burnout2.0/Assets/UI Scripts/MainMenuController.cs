using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
    
{
    public GameObject CreditsPanel;

    void Start()
    {
        CreditsPanel.SetActive(false);
    }

    public void showCredits()
    {
        CreditsPanel.SetActive(true);
    }
    public void closeCredits()
    {
        CreditsPanel.SetActive(false);
    }
    public void PlayGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
}
