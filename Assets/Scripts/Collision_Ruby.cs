using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Ruby : MonoBehaviour
{
  
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
            
            Destroy(this.gameObject);
        }
    }
}
