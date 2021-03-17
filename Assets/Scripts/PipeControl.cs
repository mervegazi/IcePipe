using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AmazingAssets.CurvedWorld.Example;
public class PipeControl : MonoBehaviour
{
    public ChunkSpawner chunkSpawner;
    void Start()
    {
        chunkSpawner = GameObject.Find("SpawmPipe").GetComponent<ChunkSpawner>();
    }

   
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="pipetag")
        {
            chunkSpawner.moveGroundFont(other.gameObject.transform); //cameraya bir box collider koyduk ona değidiğinde pipe ın yerinin değişmesi için
        }
    }
}
