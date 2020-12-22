using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Emerald : MonoBehaviour
{
    int puan=0;

    
    void Start()
    {
        
    }

    void Update()
    {
        
    }   
    private void OnCollisionEnter(Collision Col)
    {
        if (Col.gameObject.tag == "playertag" || Col.gameObject.tag == "sledtag")
        {
            puan += 10;
            Destroy(this.gameObject);
        }
    }
}
