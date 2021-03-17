using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Ruby : MonoBehaviour
{

    private void OnCollisionEnter(Collision Col)
    {
        if (Col.gameObject.tag == "playertag" || Col.gameObject.tag == "sledtag")
        {
            Player.isAccelerating = true;
            
            Destroy(this.gameObject);
        }
    }
}
