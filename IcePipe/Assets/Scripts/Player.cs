using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    float playerposx;
    public float speed;
   
    Vector3 distance;
    Quaternion rotation;
    float CurrentX, rotateX;
    public GameObject bos;

    void Start()
    {
        playerposx= this.transform.position.x; //değişkene playerin pozisyonunu aldık.
        speed = 8;                             //player in ve onu takip eden kameranın x ekseninde hızı.

       
        distance = new Vector3(0,0.8f,0);
      

    }

    void Update()
    {
        
        playerposx -= Time.deltaTime * speed;                                              //playerin x'inin hızını ayarladık
        Vector3 pos = new Vector3(playerposx, transform.position.y, transform.position.z); //hız değerini x pozisyonuna atadık
        transform.position = pos;                                                          //ayarladığımız yeni pozisyon playerin pozisyonu olsun 


        //***Dönme Hareketi***
        if (Input.GetMouseButtonDown(0))                    //mause basıldığında 
        {
            CurrentX = 180;                                 //Playerin mause basıldığında başladığı x konumu ifade ediyor kordinat sisteminde düşünülebilir her zaman borunun ortasına ve altına dönsün ve her tıklayışta oradan başlasın hareket etmeye 
        }
        if (Input.GetMouseButton(0))                        //basılı tutulduğu sürece
        {
            CurrentX += Input.GetAxis("Mouse X")*5;           //mause un x değerini currentX e ekle eğer toplama yapmazsak tek bir değer olduğu için yukarıda kalıcak karakter her basışta 
            rotation = Quaternion.Euler(-CurrentX, 0, 0);   //Quaternion dairesel hareket için kullanılır, -(eksi) karakterin altından dönmesi için - Currentx diyoruz.
            rotateX = Input.GetAxis("Mouse X")*5;             //mause un rotasyonunu rotateX e ata 
            transform.position = bos.transform.position + rotation * distance; //yeni pozisyonumuz = orta nokta objemizin(centerpoint) pozisyonu + dairesel hareketli mause x pozisyonu * mesafeyle çarpıyoruz(kendi etrafında dönmesin boru etrafında dönsün diye)
            transform.Rotate(new Vector3(-rotateX,0,0));    // rotasyonumuzu mause'un rstasyonuna göre atadık. altından dönsün diye - verdik
        }
        if (Input.GetMouseButtonUp(0))                      // mause tan elimizi çekince
        {
            float x = transform.rotation.x;                                  // x rotasyonumuzu al
            Vector3 lerp = Vector3.Lerp(new Vector3(x,0,0),Vector3.zero,5f); // 5f hızında yavaşça akışkan hareketle player orta noktaya kayarken düzelsin ve düzgün kalsın.
            transform.rotation = Quaternion.Euler(lerp);                     // yeni rotasyonumuzu atadık 
        }
        //***Bitiş***


    }
}











//*****PLAYERİN HAREKETİ******
//tanımlar:
//float x, y, z, counter, speedcapsule;
//bool ismove;
//float width, height;
//Starta yazılacaklar:
//width = .72f;
//height = .85f;
//speedcapsule = 2;
//counter = playerposx + 3; //??

//Update yazılacaklar:
//y = transform.position.y;
//z = transform.position.z;
//x = pos.x;

//if (y < -0.44f || ismove)                             // y değeri -0.44 ten büyükse: yani player yan duvarların ortasına kadar gelmişse veya ismove:haraket varsa               
//{
//    if (Input.GetMouseButton(0))                    //sağ tık basılıysa 
//    {
//        ismove = true;                              //hareket true olsun
//        counter += Time.deltaTime * speedcapsule;   //sayıyı zamana göre basıldıkça arttır ve her arttırışta dönme hızıyla çarp (dönme hızı vermezsek yerinde kalıyor) ??

//        y = Mathf.Cos(counter) * width;             //dönüşü yap
//        z = Mathf.Sin(counter) * height;
//    }
//    if (Input.GetMouseButtonUp(0))                  // sağ tık basarken elimizi çektiğimizde 
//    {
//        counter = 3;                                 // sayı 3 olsun                ??
//        ismove = false;                             // hareketi durdur
//    }

//    if (Input.GetMouseButton(1))                    //sol tık basılıysa 
//    {
//        ismove = true;                              //hareket true olsun

//        counter -= Time.deltaTime * speedcapsule;   //sayıyı zamana göre basıldıkça azalt çünkü diğer tarafa dönsün ve her eksilmede dönme hızıyla çarp(dönme hızı vermezsek yerinde kalıyor) ??

//        y = Mathf.Cos(counter) * width;             //dönüşü yap
//        z = Mathf.Sin(counter) * height;
//    }
//    if (Input.GetMouseButtonUp(1))                  // sol tık basarken elimizi çektiğimizde 
//    {
//        counter = 3;                                // sayı 3 olsun                ??
//        ismove = false;                             // hareketi durdur
//    }
//    Debug.Log(counter);

//}

//transform.position = new Vector3(x, y, z);          //koşuları sağlayıp pozisyonu değiştir.

//*****hareket sonu*****   
