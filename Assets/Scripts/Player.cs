using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
     public GameObject particle;
    float playerposx;
    public float speed;

    Vector3 distance;
    Quaternion rotation;
    float CurrentX, rotateX;
    public GameObject bos;

    public int puan=0;
    public Text puantext;
    public static bool isAccelerating;

    public int maxHealth = 30;
    public int currentHealth;
    public Healthbar healthBar;

    public GameObject gameoverpanel;
    public Text GameoverpuanText;
    public int toplamCoin;

    void Start()
    {
        gameoverpanel.SetActive(false);

        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        playerposx = this.transform.position.x; //değişkene playerin pozisyonunu aldık.
        speed = 8;                             //player in ve onu takip eden kameranın x ekseninde hızı.

        distance = new Vector3(0, 0.78333f, 0);

    }
    bool isokay,isokay2,isokay3;
    float counter,counter2;

    public object GameObject { get; private set; }

    void Update()
    {

        puantext.text = puan.ToString();

        if (!isokay2)
        {
        playerposx -= Time.deltaTime * speed;                                              //playerin x'inin hızını ayarladık
        Vector3 pos = new Vector3(playerposx, transform.position.y, transform.position.z); //hız değerini x pozisyonuna atadık
        transform.position = pos;                                                          //ayarladığımız yeni pozisyon playerin pozisyonu olsun 

        }

        //***Dönme Hareketi***
        if (Input.GetMouseButtonDown(0))                    //mause basıldığında 
        {
            CurrentX = 180;                                 //Playerin mause basıldığında başladığı x konumu ifade ediyor kordinat sisteminde düşünülebilir her zaman borunun ortasına ve altına dönsün ve her tıklayışta oradan başlasın hareket etmeye 
            isokay2 = true;
        }
        if (Input.GetMouseButton(0))                        //basılı tutulduğu sürece
        {
            
            if (isokay2)
            {
            CurrentX += Input.GetAxis("Mouse X")* 4.5f;           //mause un x değerini currentX e ekle eğer toplama yapmazsak tek bir değer olduğu için yukarıda kalıcak karakter her basışta 
            rotation = Quaternion.Euler(-CurrentX, 0, 0);     //Quaternion dairesel hareket için kullanılır, -(eksi) karakterin altından dönmesi için - Currentx diyoruz.
            rotateX = Input.GetAxis("Mouse X")* 4.5f;             //mause un rotasyonunu rotateX e ata 
            transform.position = bos.transform.position + rotation * distance; //yeni pozisyonumuz = orta nokta objemizin(centerpoint) pozisyonu + dairesel hareketli mause x rotasyonu * mesafeyle çarpıyoruz(kendi etrafında dönmesin boru etrafında dönsün diye)
            transform.Rotate(new Vector3(-rotateX, 0, 0));    // rotasyonumuzu mause'un rstasyonuna göre atadık. altından dönsün diye - verdik
                playerposx -= Time.deltaTime * speed;                                              //playerin x'inin hızını ayarladık
                Vector3 pos = new Vector3(playerposx, transform.position.y, transform.position.z); //hız değerini x pozisyonuna atadık
                transform.position = pos;
            }
        }
        if (Input.GetMouseButtonUp(0))                      // mause tan elimizi çekince
        {
            float x = transform.rotation.x;                                  // x rotasyonumuzu al
            Vector3 lerp = Vector3.Lerp(new Vector3(x, 0, 0), Vector3.zero, 5f); // 5f hızında yavaşça akışkan hareketle player orta noktaya kayarken düzelsin ve düzgün kalsın.
            transform.rotation = Quaternion.Euler(lerp);// yeni rotasyonumuzu atadık 
            isokay2 = false;
        }
        //***Bitiş***

        if (isAccelerating) //collisionRuby den gelen isAccelerating değişkeni true ise hızı arttır 
        {
            speed += 5;
            isAccelerating = false;
            isokay = true;

        }
        if (isokay)
        {
            
            counter += Time.deltaTime; //hızı 5 saniyeliğine arttırsın
            if (counter>=5)
            {
                speed -= 5;
                counter = 0;
                isokay = false;
                
            }
        }
        if (isokay3)//ruby i alınca 5 saniye boyunca yani hızlı modda kalırken can azalmasın diye yaptım.
        {
            counter2 += Time.deltaTime;
            if (counter2 >= 5)
            {
                counter2 = 0;
                isokay3 = false;

            }
        }

    }
    private void OnCollisionEnter(Collision Col) //Player bir şeye değince
    {
        if (Col.gameObject.tag == "emeraldtag") //emeralda değdiğinde puan arttır
        {
            this.transform.GetChild(0).GetChild(0).GetComponent<ParticleSystem>().Play();
            puan++;
            
        }
        if (Col.gameObject.tag == "rubytag")
        {
            this.transform.GetChild(1).GetChild(0).GetComponent<ParticleSystem>().Play();
            isokay3 = true;
        }
        if (Col.gameObject.tag == "icetag" &&!isokay3) //ice a değince canı azalt
        {
                TakeDamage(1);
           
        }
       
        if (Col.gameObject.tag == "diamondtag") //diamond ı alınca canı fulleme
        {
            this.transform.GetChild(2).GetChild(0).GetComponent<ParticleSystem>().Play();
            healthBar.SetMaxHealth(maxHealth);
            currentHealth = maxHealth;
        }

    }
 
   public void TakeDamage(int damage) //can azaltma ve bittiğinde gamover paneli açılımı
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if (currentHealth == 0)
        {
            //buraya bir patlama efekti. 
            Time.timeScale = 0;
            GameoverpuanText.text = "Emerald: "+puantext.text;
            toplamCoin= puan;
            PlayerPrefs.SetInt("savedcoin", toplamCoin);
            gameoverpanel.SetActive(true);           

        }
    }

}





 
