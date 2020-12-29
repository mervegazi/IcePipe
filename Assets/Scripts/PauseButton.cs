using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{
    public GameObject panel;
    bool IsPaused = false;

    private void Start()
    {
        panel.SetActive(false);
    }
    public void PauseGame()
    {
        if (IsPaused)
        {
            Time.timeScale = 1;
            panel.SetActive(false);
            IsPaused = false;

        }
        else
        {
            Time.timeScale = 0;
            panel.SetActive(true);
            IsPaused = true;
            
        }
    }

}
