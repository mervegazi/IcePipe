using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{ 
    public Text EmeraldValueText;
    public Text EmeraldValueText2;
    public int toplamCoin;
    
    void Start()
    {
        //PlayerPrefs.SetInt("totalcoin", 100);
       Settext();
    }
    public void Settext()
    {
        PlayerPrefs.SetInt("totalcoin", PlayerPrefs.GetInt("savedcoin") + PlayerPrefs.GetInt("totalcoin", 0));
        PlayerPrefs.SetInt("savedcoin", 0);
        toplamCoin = PlayerPrefs.GetInt("totalcoin");
        EmeraldValueText.text = toplamCoin.ToString();
        if (EmeraldValueText2 != null)
        {
            EmeraldValueText2.text = toplamCoin.ToString();
        }
        //else
        //{
        //    Debug.LogError(gameObject.name);
        //}
        if (PlayerPrefs.GetInt("totalcoin")<=0)
        {
            toplamCoin = 0;
            PlayerPrefs.SetInt("totalcoin", 0);
        }
    }
}
