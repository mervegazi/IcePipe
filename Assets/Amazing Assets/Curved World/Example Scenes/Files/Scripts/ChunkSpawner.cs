using UnityEngine;
using System.Collections.Generic;
using System.Linq;


namespace AmazingAssets.CurvedWorld.Example
{
    public class ChunkSpawner : MonoBehaviour
    {
        public enum AXIS { XPositive, XNegative, ZPositive, ZNegative }

        public GameObject[] chunks;
        public int initialSpawnCount = 5;
        public float destoryZone = 300;

        [Space(10)]
        public AXIS axis;

        [HideInInspector]
        public Vector3 moveDirection = new Vector3(-1, 0, 0);
        public float movingSpeed = 1;


        public float chunkSize = 60;
        GameObject lastChunk;


        void Awake()
        {
            initialSpawnCount = initialSpawnCount > chunks.Length ? initialSpawnCount : chunks.Length;


           
        }

        public void DestroyChunk(RunnerChunk thisChunk)
        {
            Vector3 newPos = lastChunk.transform.position;
            switch (axis)
            {
                case AXIS.XPositive:
                    newPos.x -= chunkSize;
                    break;

                case AXIS.XNegative:
                    newPos.x += chunkSize;
                    break;

                case AXIS.ZPositive:
                    break;

                case AXIS.ZNegative:
                    break;
            }



            lastChunk = thisChunk.gameObject;
            lastChunk.transform.position = newPos;
        }
        public int GetTheFrontGroundObject()
        {
            int foundIndex = -1;
            float closestZ = -999999999;
            for (int i = 0; i < chunks.Length; i++)
            {
                if (chunks[i].transform.localPosition.x > closestZ)
                {
                    foundIndex = i;
                    closestZ = chunks[i].transform.localPosition.x;
                }
            }
            return foundIndex;
        }
        public void moveGroundFont(Transform chunk)//pipe yer değiştirme
        {
            int frontestGround = GetTheFrontGroundObject();
            Vector3 groundPos = chunks[frontestGround].transform.localPosition;//en uzaktaki pipe pozisyonunu groundPos a atıyor.
            groundPos.x -= chunk.GetChild(0).transform.GetComponent<MeshCollider>().bounds.size.x*chunks.Length; //pipeların uzunluğunu alıp son pipe ın arkasına tekrar koyuyor pipeları
            chunk.transform.localPosition = groundPos;
            //Debug.LogError(chunk.gameObject.name + " " + chunk.transform.localPosition.x + " Frontest " + frontestGround);
        }
    }
}
