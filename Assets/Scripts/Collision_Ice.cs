using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Ice : MonoBehaviour
{
    Transform ice;
   
    void Start()
    {
        ice = transform.GetChild(0); //pivotsuz parent
       
    }

   
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision Col)                                        //collider değdiğinde koşulları yapsın burada oncollider kullanmadık çünkü colladerın is trigerı açık olması lazım kodun çalışması için bizim projemizde is tigger kapalı kalmalı oncolosion tgiggerın açık olup olmadığına bakmaz.
    {
        Transform[] allChildren = ice.GetComponentsInChildren<Transform>();             //Transformadan bir dizi oluşturuyoruz tüm parçaların yani child ların transformunu atıyoruz.

        if (Col.gameObject.tag == "playertag" || Col.gameObject.tag == "sledtag")       //buzumuzun colliderlarına tagı playertag veya sledtag olan bir obje çarptıysa  
        {

            transform.GetChild(1).GetComponent<MeshRenderer>().enabled = false;         //buzumuzun içindeki dış kaplama collider'ı kapat
            transform.GetChild(2).GetComponent<MeshRenderer>().enabled = false;         //buzumuzun içindeki covering isimli kaplamayı da kapat

                for (int i = 1; i <= allChildren.Length-1; i++)                         //burada -1 vermemizin nedeni sadece child ı değil parent i de sayıyor 0. değer parent olduğundan hata veriyordu.
                {
                    allChildren[i].GetComponent<BoxCollider>().enabled = true;          //döngüye her girdiğinde sırası gelen childın boxcollider ını aç ki parçalanabilsin.
                    allChildren[i].GetComponent<Rigidbody>().useGravity = true;         //döngüye her girdiğinde sırası gelen childın yer çekimini aç parçalandıktan sonra parçalar uçmayıp yere düşşün.
            }
         
        }
    }    
}
