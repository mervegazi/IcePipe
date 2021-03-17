using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using AmazingAssets.CurvedWorld;

public class GameManager : MonoBehaviour
{
    public GameObject pipe1;
    public GameObject pipe2;
    GameObject player;
    float length = 0;
    bool siraikide;

    int Rand;
    public GameObject[] Ices;
    Quaternion rotation;
    Vector3 distance;    

    public GameObject emerald;
    public GameObject ruby;
    public GameObject diamond;
    public GameObject[] Characters;
    public GameObject[] Sleds;
    float pipetime = 2f;
    float pipetime2 = 2f;
    float pipehorizontal;
    float pipevertical;
    public CurvedWorldController curvedC;

    void Start()
    {
        this.gameObject.GetComponent<AudioSource>().Play();

        pipetime =2;
        pipetime2 = 2;
        curvedC = GameObject.Find("Curved World Controller").GetComponent<CurvedWorldController>();     
        player = GameObject.FindGameObjectWithTag("playertag");

        length = pipe1.transform.localScale.y * 2;                      //burada bir uzunluk değeri elde ettik borunun uzunluğunun 2 katı değerini aldık çünkü diğer boruyu ilk borunun yanına eklemek istiyoruz.
        distance = new Vector3(0.9f, 0, 0);

        for(int i=0;i<=10;i++)                                          //başlangıçta hızlı bir şekilde 15 tane buz oluştursun 
        {
            ProduceIcesStart(i);    
        }
        if (PlayerPrefs.GetString("CharacterChoose", "")== "Penguin") //isme göre shop ekranında oluşturulan datayı burada al ve o karakteri aktif et
        {
            Characters[0].SetActive(false);
            Characters[1].SetActive(false);
            Characters[2].SetActive(false);
            Characters[3].SetActive(true);
            Characters[4].SetActive(false);
            Characters[5].SetActive(false);
            Characters[6].SetActive(false);
        }
        if (PlayerPrefs.GetString("CharacterChoose", "") == "Panda")
        {
            Characters[0].SetActive(false);
            Characters[1].SetActive(false);
            Characters[2].SetActive(true);
            Characters[3].SetActive(false);
            Characters[4].SetActive(false);
            Characters[5].SetActive(false);
            Characters[6].SetActive(false);
        }
        if (PlayerPrefs.GetString("CharacterChoose", "") == "Pig")
        {
            Characters[0].SetActive(false);
            Characters[1].SetActive(false);
            Characters[2].SetActive(false);
            Characters[3].SetActive(true);
            Characters[4].SetActive(false);
            Characters[5].SetActive(false);
            Characters[6].SetActive(false);
        }
        if (PlayerPrefs.GetString("CharacterChoose", "") == "Rabbit")
        {
            Characters[0].SetActive(false);
            Characters[1].SetActive(false);
            Characters[2].SetActive(false);
            Characters[3].SetActive(false);
            Characters[4].SetActive(false);
            Characters[5].SetActive(true);
            Characters[6].SetActive(false);
        }
        if (PlayerPrefs.GetString("CharacterChoose", "") == "Monkey")
        {
            Characters[0].SetActive(false);
            Characters[1].SetActive(true);
            Characters[2].SetActive(false);
            Characters[3].SetActive(false);
            Characters[4].SetActive(false);
            Characters[5].SetActive(false);
            Characters[6].SetActive(false);
        }
        if (PlayerPrefs.GetString("CharacterChoose", "") == "Tigger")
        {
            Characters[0].SetActive(false);
            Characters[1].SetActive(false);
            Characters[2].SetActive(false);
            Characters[3].SetActive(false);
            Characters[4].SetActive(false);
            Characters[5].SetActive(false);
            Characters[6].SetActive(true);
        }
        if (PlayerPrefs.GetString("CharacterChoose", "") == "Elephand")
        {
            Characters[0].SetActive(true);
            Characters[1].SetActive(false);
            Characters[2].SetActive(false);
            Characters[3].SetActive(false);
            Characters[4].SetActive(false);
            Characters[5].SetActive(false);
            Characters[6].SetActive(false);
        }
        if (PlayerPrefs.GetString("SledChoose", "") == "Brown Sled")
        {
           Sleds[0].SetActive(true);
           Sleds[1].SetActive(false);
           Sleds[2].SetActive(false);
           Sleds[3].SetActive(false);
           Sleds[4].SetActive(false);
           Sleds[5].SetActive(false);
          
        }
        if (PlayerPrefs.GetString("SledChoose", "") == "Wooden Sled")
        {
            Sleds[0].SetActive(false);
            Sleds[1].SetActive(true);
            Sleds[2].SetActive(false);
            Sleds[3].SetActive(false);
            Sleds[4].SetActive(false);
            Sleds[5].SetActive(false);
          
        }
        if (PlayerPrefs.GetString("SledChoose", "") == "Blue Sled")
        {
            Sleds[0].SetActive(false);
            Sleds[1].SetActive(false);
            Sleds[2].SetActive(true);
            Sleds[3].SetActive(false);
            Sleds[4].SetActive(false);
            Sleds[5].SetActive(false);
           
        }
        if (PlayerPrefs.GetString("SledChoose", "") == "Red Sled")
        {
            Sleds[0].SetActive(false);
            Sleds[1].SetActive(false);
            Sleds[2].SetActive(false);
            Sleds[3].SetActive(true);
            Sleds[4].SetActive(false);
            Sleds[5].SetActive(false);
            
        }
        if (PlayerPrefs.GetString("SledChoose", "") == "Snow Monster")
        {
            Sleds[0].SetActive(false);
            Sleds[1].SetActive(false);
            Sleds[2].SetActive(false);
            Sleds[3].SetActive(false);
            Sleds[4].SetActive(true);
            Sleds[5].SetActive(false);
           
        }
        if (PlayerPrefs.GetString("SledChoose", "") == "Super Sled")
        {
            Sleds[0].SetActive(false);
            Sleds[1].SetActive(false);
            Sleds[2].SetActive(false);
            Sleds[3].SetActive(false);
            Sleds[4].SetActive(false);
            Sleds[5].SetActive(true);
            
        }
    }  
    float counter, counter2, counter3,counter4,counter5;
    void Update()
    {
        counter5 += Time.deltaTime;
        if (counter5 >= 60)                                                                                                   //60 saniyede bir oyunun hızı 0.1 kadar artsın         
        {
            Time.timeScale += 0.1f;
            counter5 = 0;
        }
       
        if (pipetime==0)                                                                                                        //pipe Shaderin rastgele yumuşak dönüşler yapması için 40 ile -40 arasında bir değerde 2 saniyede 1 yumuşak dönüş yapsın.
        {
            pipehorizontal = Random.Range(-40, 40);
        }
        pipetime += Time.deltaTime;
       
        curvedC.bendHorizontalSize = Mathf.Lerp(curvedC.bendHorizontalSize, pipehorizontal, Time.deltaTime*.5f);             // bir konumdan başka bir konuma yavaşça taşınması için lerp kullanıyoruz. ne kadar zamanda taşınması gerektiğini belirtmemiz lazım. Yavaş olsun diye 0.5 verdik.
        if (Mathf.Abs(curvedC.bendHorizontalSize - pipehorizontal) <= .5f)                                                   //iki değer arasındaki fark 0.5 ten küçükse pipetime sıfırla (şimdiki değeri - random verdiğimiz değer)
        {
            pipetime = 0;
        }

       // --------------------------------------------------

        if(pipetime2 == 0)
        {
            pipevertical = Random.Range(-40, 40);
        }
        pipetime2 += Time.deltaTime;

        curvedC.bendVerticalSize = Mathf.Lerp(curvedC.bendVerticalSize, pipevertical, Time.deltaTime * .5f);
        if(Mathf.Abs(curvedC.bendVerticalSize-pipevertical)<=.5f)
        {
            pipetime2 = 0;
        }
        //}
        //if (!siraikide)                                                                                                      //boruların playera bağlı olarak sıralı gelip sonsuza kadar devam etmesini sağlıyoruz.
        //{
        //    if (player.transform.position.x <= pipe2.transform.position.x+length/2 -5)                                       //burada player, 2. borunun orta noktasına değil de, başına geldiği zaman diğer boru yerini alsın dedik(+length/2(/2 demezsek en başa atar playerı)). boruların geçişi sırasında arada boşluk olmasın diye -5 verdik.
        //    {
        //        pipe1.transform.position -= new Vector3(length *2, 0, 0);
        //        siraikide = true;
        //    }
        //}
        //else if (siraikide)
        //{
        //    if (player.transform.position.x <= pipe1.transform.position.x+length/2-5)
        //    {
        //        pipe2.transform.position -= new Vector3(length*2 , 0, 0);
        //        siraikide = false;
        //    }
        //}

        counter += Time.deltaTime; 
        if(counter>=0.8f)               //0.4 saniyede bir buzları oluştursun
        {
            ProduceIces();   
            counter = 0;
        }

        counter2 += Time.deltaTime;
        if(counter2>=0.8f)
        {
            ProduceEmerald();
            counter2 = 0;
        }
        counter3 += Time.deltaTime;
        if(counter3>=25f)
        {
            ProduceRuby();
            counter3 = 0;
        }
        counter4 += Time.deltaTime;
        if (counter4 >= 56f)
        {
            ProduceDiamond();
            counter4 = 0;
        }
    }
     void ProduceIces()                                                                 //buz oluşturma 
    {
        Rand = Random.Range(0, Ices.Length);                                            // oluşturduğumuz buz dizisinin uzunluk sayısının arasından random sayı oluştur.
        var rand = Random.Range(-180, 180);                                             //-180 ie 10 arası random sayı oluştur.
        Vector3 vec = new Vector3(player.transform.position.x-90, 0, 0);                //buzların konumu x ekseninde playerdan -90 kadar uzakta oluşsun.(-) terse gittiğimiz için.
        GameObject Clone = Instantiate(Ices[Rand],vec, Quaternion.identity);            //clone buz oluştur( oluşturduğmuz diziden rastgele bir buzu seç, belirlediğimiz pozisyonda olsun, rotasyonu boş: salt okunur en uygun yere yapar.
        Clone.transform.rotation = Quaternion.Euler(new Vector3(rand, 0, 0));           //rotasyonu burada ayrı veriyoruz -180 ile 180 arasında olsun

    }
    void ProduceIcesStart(int i)                                                        //başlangıçta player a daha yakın buzları oluştursun
    {
        Rand = Random.Range(0, Ices.Length);
        var rand = Random.Range(-180, 180);
        Vector3 vec = new Vector3(player.transform.position.x - 15*i-15, 0, 0);
        GameObject Clone = Instantiate(Ices[Rand], vec, Quaternion.identity);
        Clone.transform.rotation = Quaternion.Euler(new Vector3(rand, 0, 0));
    }

    void ProduceEmerald()
    {
        var rand = Random.Range(-180, 180);
        Vector3 vec = new Vector3(player.transform.position.x - 90, 0, 0);
        GameObject Clone = Instantiate(emerald, vec, Quaternion.identity);
        Clone.transform.rotation = Quaternion.Euler(new Vector3(rand, 0, 0));
    }
    
    void ProduceRuby()
    {
        var rand = Random.Range(-180, 180);
        Vector3 vec = new Vector3(player.transform.position.x - 90, 0, 0);
        GameObject Clone = Instantiate(ruby, vec, Quaternion.identity);
        Clone.transform.rotation = Quaternion.Euler(new Vector3(rand, 0, 0));
    }
    void ProduceDiamond()
    {
        var rand = Random.Range(-180, 180);
        Vector3 vec = new Vector3(player.transform.position.x - 90, 0, 0);
        GameObject Clone = Instantiate(diamond, vec, Quaternion.identity);
        Clone.transform.rotation = Quaternion.Euler(new Vector3(rand, 0, 0)); 
    }
}
