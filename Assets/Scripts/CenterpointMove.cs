using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterpointMove : MonoBehaviour
{

    public GameObject Player;
    float cpposx;

    void Start()
    {
        cpposx = this.transform.position.x; // değişkene centerpoint pozisyonunu aldık.

    }

   
    void Update()
    {
        cpposx -= Time.deltaTime * Player.GetComponent<Player>().speed;                 //cp x'inin hızını playerda tanımladığımız hıza ayarladık 
        Vector3 pos = new Vector3(cpposx, 0, 0);                                        //hız değerini x pozisyonuna atadık
        transform.position = pos;                                                       //ayarladığımız yeni pozisyon cpnin pozisyonu olsun 

    }
}
