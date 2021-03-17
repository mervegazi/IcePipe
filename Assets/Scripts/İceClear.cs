using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class İceClear : MonoBehaviour
{

    void Start()
    {
        Destroy(this.gameObject, 25); //25 saniye sonra buzları silsin
    }   
}
