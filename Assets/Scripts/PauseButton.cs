using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{
    public GameObject panel;
    bool IsPaused;
    public void PauseGame()
    {
        if (IsPaused) 
        {   
            panel.SetActive(false);
            Time.timeScale = 1;
            IsPaused = false;
        }
        else
        {
            panel.SetActive(true);
            Time.timeScale = 0; // pause tuşuna basınca zamanı durdurma
            IsPaused = true;
        }
    }
}
