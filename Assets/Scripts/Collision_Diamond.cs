using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Diamond : MonoBehaviour
{
    private void OnCollisionEnter(Collision Col)
    {
        if (Col.gameObject.tag == "playertag" || Col.gameObject.tag == "sledtag")
        {
            
            Destroy(this.gameObject);
        }
    }
}
