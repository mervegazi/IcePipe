using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmeraldRot : MonoBehaviour
{
   
    void Start()
    {
        transform.rotation = Quaternion.Euler(0, 180, 0); //kendi etrafındaki rostasyonunu sabitledik dik dursun diye
    }

  
    void Update()
    {
        transform.Rotate(new Vector3(0, Time.deltaTime * 150, 0)); //kendi etrafındaki rostasyonu y ekseninde sürekli dönsün
    }
        
}
