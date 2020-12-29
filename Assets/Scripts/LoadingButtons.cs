using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingButtons : MonoBehaviour
{
    public void ManuLoad()
    {
        SceneManager.LoadScene(0);
    }
    public void RestartLoad()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void PlayLoad()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void OptionsLoad()
    {
        SceneManager.LoadScene(2);
    }
   public void BackLoad()
    {
        SceneManager.LoadScene(0);
    }
}
