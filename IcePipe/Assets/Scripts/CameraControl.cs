using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public GameObject Player;
    float cameraposx;
   
    void Start()
    {
        cameraposx = this.transform.position.x; // değişkene cameranın pozisyonunu aldık.
    }

    void Update()
    {

        cameraposx -= Time.deltaTime * Player.GetComponent<Player>().speed;                 //cameranın x'inin hızını playerda tanımladığımız hıza ayarladık 
        Vector3 pos = new Vector3(cameraposx, transform.position.y, transform.position.z);  //hız değerini x pozisyonuna atadık
        transform.position = pos;                                                           //ayarladığımız yeni pozisyon cameranın pozisyonu olsun 
    }
}
