using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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


    
    

    void Start()
    {

       
        player = GameObject.FindGameObjectWithTag("playertag");

        length = pipe1.transform.localScale.y * 2;                      //burada bir uzunluk değeri elde ettik borunun uzunluğunun 2 katı değerini aldık çünkü diğer boruyu ilk borunun yanına eklemek istiyoruz.


        distance = new Vector3(0.9f, 0, 0);

        for(int i=0;i<=13;i++)                                          //başlangıçta hızlı bir şekilde 15 tane buz oluştursun 
        {
            ProduceIcesStart(i);
           
        }    

    }
    //TODO: burada bir şey yapacağım
    float counter, counter2, counter3,counter4;
    void Update()
    {

        if (!siraikide)                                                                                                      //boruların playera bağlı olarak sıralı gelip sonsuza kadar devam etmesini sağlıyoruz.
        {
            if (player.transform.position.x <= pipe2.transform.position.x+length/2 -5)                                       //burada player, 2. borunun orta noktasına değil de, başına geldiği zaman diğer boru yerini alsın dedik(+length/2(/2 demezsek en başa atar playerı)). boruların geçişi sırasında arada boşluk olmasın diye -5 verdik.
            {
                pipe1.transform.position -= new Vector3(length *2, 0, 0);
                siraikide = true;
            }
        }
        else if (siraikide)
        {
            if (player.transform.position.x <= pipe1.transform.position.x+length/2-5)
            {
                pipe2.transform.position -= new Vector3(length*2 , 0, 0);
                siraikide = false;
            }
        }




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
