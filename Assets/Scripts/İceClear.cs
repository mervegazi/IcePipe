using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class İceClear : MonoBehaviour
{

    void Start()
    {
        Destroy(this.gameObject, 18); //15 saniye sonra buzları silsin
    }   
}
