using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Ruby : MonoBehaviour
{
    public AudioSource coinsound;
    public AudioClip coinaudioclip;

    private void Start()
    {
        coinsound = GameObject.Find("coinaudio").GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision Col)
    {
        if (Col.gameObject.tag == "playertag" || Col.gameObject.tag == "sledtag") //playere değince player scriptindeki isAccelerating değişkenini truelasın ki hızı arrtırabilelim.
        {
            Player.isAccelerating = true;
            coinsound.PlayOneShot(coinaudioclip); //alma sesi çalsın
            Destroy(this.gameObject);
        }
    }
}
