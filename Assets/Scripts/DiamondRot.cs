using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondRot : MonoBehaviour
{
    
    void Start()
    {
      transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    
    void Update()
    {
        transform.Rotate(new Vector3(0, Time.deltaTime * 200, 0));
    }
}
