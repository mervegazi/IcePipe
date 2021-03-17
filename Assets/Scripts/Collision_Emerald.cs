using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Emerald : MonoBehaviour
{
    public AudioSource coinsound;
    public AudioClip coinaudioclip;

    private void Start()
    {
        coinsound = GameObject.Find("emeraldaudio").GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision Col)
    {
        
        if (Col.gameObject.tag == "playertag" || Col.gameObject.tag == "sledtag") //emeralda oyuncu veya kızak değdiğinde  objeyi yok et
        {

           coinsound.PlayOneShot(coinaudioclip); //alma sesi çalsın
            Destroy(this.gameObject);

        
        }
    }
   
}
