using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmeraldRot : MonoBehaviour
{
   
    void Start()
    {
        transform.rotation = Quaternion.Euler(0, 180, 0);
    }

  
    void Update()
    {
        transform.Rotate(new Vector3(0, Time.deltaTime * 150, 0));
    }
        
}
