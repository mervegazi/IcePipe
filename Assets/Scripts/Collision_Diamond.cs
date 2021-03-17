using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Diamond : MonoBehaviour
{
    public AudioSource coinsound;
    public AudioClip coinaudioclip;

    private void Start()
    {
        coinsound = GameObject.Find("coinaudio").GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision Col)
    {
        if (Col.gameObject.tag == "playertag" || Col.gameObject.tag == "sledtag")
        {

            coinsound.PlayOneShot(coinaudioclip); //alma sesi çalsın
            Destroy(this.gameObject);
        }
    }
}
