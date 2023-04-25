using UnityEngine;
using UnityEngine.Events;

public class CloseButton : MonoBehaviour 
{
    public GameObject PausePanel;
    public GameObject PauseButton;


    void Start()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void pauseGame()
    {
        
        PausePanel.SetActive(true);
        PauseButton.SetActive(false);
        Time.timeScale = 0;
    }

    public void unpauseGame()
    {
        PausePanel.SetActive(false);
        PauseButton.SetActive(true);
        Time.timeScale = 1;
    }
}