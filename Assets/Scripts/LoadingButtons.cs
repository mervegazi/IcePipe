using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingButtons : MonoBehaviour
{
    
    public GameObject ShopPanel;
    public GameObject Allbutton;
    public GameObject Characterbutton;
    public GameObject Sledbutton;
    public GameObject Emeraldbutton;
    public GameObject OptionsPanel;

    public GameObject[] Animals;
    public GameObject[] Sleds;
    public GameObject[] Emeralds;


    public GameObject ChangeImage;
    Image item;
    public GameObject NameItem;
    public GameObject SelectPopup;
    public Text PopupText;
    public GameObject Sellbutton;
    public GameObject StartsEmerald;
    int Coin;
    public GameObject Selectbutton;
    public GameObject SellPopup;
    int toplamCoin;
    public GameObject ChoosePic;


    public void ManuLoad() //Sahne yüklemeleri...
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 0;
    }
    public void RestartLoad()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;     //zamanı baştan başlatarak normal hızda ilerlemesini sağlarız 2 yazarsak 2x ilerler oyunda zaman 
    }
 
   public void OptionsLoad()
    {
        OptionsPanel.SetActive(true);
    }
   public void BackLoad()
    {
        SceneManager.LoadScene(0);
    }
    public void ShopLoad() 
    {
        ShopPanel.SetActive(true); //shop panel açılsın
        Sellbutton.SetActive(false); //ilk açılışta, shop yüklendiğinde penguen seçili olduğu için sellbutton pasif olsun 

    }
    public void ShopBack()
    {
        ShopPanel.SetActive(false);
    }
    public void OptionsBack()
    {
        OptionsPanel.SetActive(false);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void AllButton()
    {
        item = Animals[0].transform.GetChild(0).GetChild(0).GetComponent<Image>();                          //buton all a ne zaman tıklarsak seçim yapmadığımızda dahi sağ seçim ekranımda penguin olsun
        ChangeImage.GetComponent<Image>().sprite = item.sprite;

        NameItem.GetComponent<Text>().text = "Penguin";                                                     //buton all a ne zaman tıklarsak seçim yapmadığımızda dahi sağ seçim isiminde penguin olsun                                   
        ChoosePic.transform.GetComponent<ChoosePic>().ChooseCharacters();                                   //ilk açılışta seçili olması gereken karakter

        if (NameItem.GetComponent<Text>().text == "Penguin" || NameItem.GetComponent<Text>().text == "Brown Sled")      //ana karakterler olan penguin ve sled seçildiğinde  Sell buton gizlensin
        {
            Sellbutton.SetActive(false);
        }
        else
        {
            Sellbutton.SetActive(true);
            Selectbutton.SetActive(false);
        }
        Allbutton.transform.GetChild(0).GetChild(0).GetComponent<Image>().enabled = true;                   //butonların altındaki düz beyaz çizgi yi basılan butona göre açma kapama
        Characterbutton.transform.GetChild(0).GetChild(0).GetComponent<Image>().enabled = false;
        Sledbutton.transform.GetChild(0).GetChild(0).GetComponent<Image>().enabled = false;
        Emeraldbutton.transform.GetChild(0).GetChild(0).GetComponent<Image>().enabled = false;

        for(int i=0; i<=Animals.Length-1;i++)                                                               //tüm karakterleri sledleri ve emeraldları sol panelde yükleme
        {
            Animals[i].SetActive(true);
        }
        for (int i = 0; i <= Sleds.Length-1; i++)
        {
            Sleds[i].SetActive(true);
        }
        for (int i = 0; i <= Emeralds.Length-1; i++)
        {
            Emeralds[i].SetActive(true);
        }
       


    }
    public void CharacterButton()
    {
        item = Animals[0].transform.GetChild(0).GetChild(0).GetComponent<Image>();
        ChangeImage.GetComponent<Image>().sprite = item.sprite;
        NameItem.GetComponent<Text>().text = "Penguin";

        ChoosePic.transform.GetComponent<ChoosePic>().ChooseCharacters(); //ilk açılışta seçili olması gereken karakter

        if (NameItem.GetComponent<Text>().text == "Penguin" || NameItem.GetComponent<Text>().text == "Brown Sled")      //ana karakterler olan penguin ve sled seçildiğinde  Sell buton gizlensin
        {
            Sellbutton.SetActive(false);
        }
        else
        {
            Sellbutton.SetActive(true);
            Selectbutton.SetActive(false);
        }
        Characterbutton.transform.GetChild(0).GetChild(0).GetComponent<Image>().enabled = true;
        Sledbutton.transform.GetChild(0).GetChild(0).GetComponent<Image>().enabled = false;
        Emeraldbutton.transform.GetChild(0).GetChild(0).GetComponent<Image>().enabled = false;
        Allbutton.transform.GetChild(0).GetChild(0).GetComponent<Image>().enabled = false;

        for (int i = 0; i <= Animals.Length-1; i++)
        {
            Animals[i].SetActive(true);
        }
        for (int i = 0; i <= Sleds.Length-1; i++)
        {
            Sleds[i].SetActive(false);
        }
        for (int i = 0; i <= Emeralds.Length-1; i++)
        {
            Emeralds[i].SetActive(false);
        }
     

    }
    public void SledButton()
    {
        NameItem.GetComponent<Text>().text = "Brown Sled";
        item = Sleds[0].transform.GetChild(0).GetChild(0).GetComponent<Image>();
        ChangeImage.GetComponent<Image>().sprite = item.sprite;

        ChoosePic.transform.GetComponent<ChoosePic>().ChooseSleds(); //ilk açılışta seçili olması gereken karakter


        if (NameItem.GetComponent<Text>().text == "Penguin" || NameItem.GetComponent<Text>().text == "Brown Sled")      //ana karakterler olan penguin ve sled seçildiğinde  Sell buton gizlensin
        {
            Sellbutton.SetActive(false);
        }
        else
        {
            Sellbutton.SetActive(true);
            Selectbutton.SetActive(false);
        }
        Sledbutton.transform.GetChild(0).GetChild(0).GetComponent<Image>().enabled = true;
        Emeraldbutton.transform.GetChild(0).GetChild(0).GetComponent<Image>().enabled = false;
        Allbutton.transform.GetChild(0).GetChild(0).GetComponent<Image>().enabled = false;
        Characterbutton.transform.GetChild(0).GetChild(0).GetComponent<Image>().enabled = false;

        for (int i = 0; i <= Animals.Length-1; i++)
        {
            Animals[i].SetActive(false);
        }
        for (int i = 0; i <= Sleds.Length-1; i++)
        {
            Sleds[i].SetActive(true);
        }
        for (int i = 0; i <= Emeralds.Length-1; i++)
        {
            Emeralds[i].SetActive(false);
        }
       
    }
    public void EmeraldButton()
    {
        NameItem.GetComponent<Text>().text = "Emerald I";
        item = Emeralds[0].transform.GetChild(0).GetChild(0).GetComponent<Image>();
        ChangeImage.GetComponent<Image>().sprite = item.sprite;


       ChoosePic.transform.GetComponent<ChoosePic>().ChooseEmerals();  //ilk açılışta seçili olması gereken karakter


        Sellbutton.SetActive(true);
        Selectbutton.SetActive(false);
        
        Emeraldbutton.transform.GetChild(0).GetChild(0).GetComponent<Image>().enabled = true;
        Allbutton.transform.GetChild(0).GetChild(0).GetComponent<Image>().enabled = false;
        Characterbutton.transform.GetChild(0).GetChild(0).GetComponent<Image>().enabled = false;
        Sledbutton.transform.GetChild(0).GetChild(0).GetComponent<Image>().enabled = false;

        for (int i = 0; i <= Animals.Length-1; i++)
        {
            Animals[i].SetActive(false);
        }
        for (int i = 0; i <= Sleds.Length-1; i++)
        {
            Sleds[i].SetActive(false);
        }
        for (int i = 0; i <= Emeralds.Length-1; i++)
        {
            Emeralds[i].SetActive(true);
        }

       

       


    }
  
    public void SellButton()
    {
        if (NameItem.GetComponent<Text>().text == "Panda")
        {
            

            if (!(PlayerPrefs.GetString("Sell", "") == "buypanda"))
            {
                Coin = StartsEmerald.transform.GetComponent<Coin>().toplamCoin;
                if (Coin>=6000)
                {                
                PlayerPrefs.SetString("Sell", "buypanda");                                  //alındığını kaydetti
                PlayerPrefs.SetInt("totalcoin", PlayerPrefs.GetInt("totalcoin", 0) - 6000); //parayı azalt ve kaydet
                StartsEmerald.transform.GetComponent<Coin>().Settext();                     //azaltılan parayı texte yazdırması için coinden Settex metodu çek
                }
                if (Coin < 6000)                                                             //bakiye yetersiz uyarısı için
                {
                    SellPopup.SetActive(true);
                }

            }
            if (PlayerPrefs.GetString("Sell", "") == "buypanda")                             //eğer alınmışsa karakter buy butonunu kapat seçme butonunu aç ve hep böyle kalsın bir kere alma işlemi gerçekleştiği için.
            {
                Sellbutton.SetActive(false);
                Selectbutton.SetActive(true);

            }

        }
        if (NameItem.GetComponent<Text>().text == "Pig")
        {


            if (!(PlayerPrefs.GetString("Sell", "") == "buypig"))
            {
                Coin = StartsEmerald.transform.GetComponent<Coin>().toplamCoin;
                if (Coin >= 3000)
                {   
                PlayerPrefs.SetString("Sell", "buypig");                                       //alındığını kaydetti
                PlayerPrefs.SetInt("totalcoin", PlayerPrefs.GetInt("totalcoin", 0) - 3000);    //parayı azalt ve kaydet
                StartsEmerald.transform.GetComponent<Coin>().Settext();                        //azaltılan parayı texte yazdırması için coinden Settex metodu çek
                }
                if (Coin < 3000)                                                               //bakiye yetersiz uyarısı için
                {
                    SellPopup.SetActive(true);
                }

            }
            if (PlayerPrefs.GetString("Sell", "") == "buypig")                                  //eğer alınmışsa karakter buy butonunu kapat seçme butonunu aç ve hep böyle kalsın bir kere alma işlemi gerçekleştiği için.
            {
                Sellbutton.SetActive(false);
                Selectbutton.SetActive(true);

            }

        }
        if (NameItem.GetComponent<Text>().text == "Elephand")
        {


            if (!(PlayerPrefs.GetString("Sell", "") == "buyelephand"))                          //karakter alınmadıysa
            {
                Coin = StartsEmerald.transform.GetComponent<Coin>().toplamCoin;
                if (Coin >= 1000)
                {    
                    PlayerPrefs.SetString("Sell", "buyelephand");                                    //alındığını kaydetti
                    PlayerPrefs.SetInt("totalcoin", PlayerPrefs.GetInt("totalcoin", 0) - 1000);      //parayı azalt ve kaydet
                    StartsEmerald.transform.GetComponent<Coin>().Settext();                          //azaltılan parayı texte yazdırması için coinden Settex metodu çek
                }
                    if (Coin < 1000)                                                                 //bakiye yetersiz uyarısı için
                {
                    SellPopup.SetActive(true);
                }

            }
            if (PlayerPrefs.GetString("Sell", "") == "buyelephand")                              //eğer alınmışsa karakter buy butonunu kapat seçme butonunu aç ve hep böyle kalsın bir kere alma işlemi gerçekleştiği için.
            {
                Sellbutton.SetActive(false);
                Selectbutton.SetActive(true);

            }

        }
        if (NameItem.GetComponent<Text>().text == "Rabbit")
        {


            if (!(PlayerPrefs.GetString("Sell", "") == "buyrabbit"))                          //karakter alınmadıysa
            {
                Coin = StartsEmerald.transform.GetComponent<Coin>().toplamCoin;
                if (Coin >= 2000)
                {                  
                    PlayerPrefs.SetString("Sell", "buyrabbit");                                    //alındığını kaydetti
                    PlayerPrefs.SetInt("totalcoin", PlayerPrefs.GetInt("totalcoin", 0) - 2000);      //parayı azalt ve kaydet
                    StartsEmerald.transform.GetComponent<Coin>().Settext();                          //azaltılan parayı texte yazdırması için coinden Settex metodu çek
                }
                    if (Coin < 2000)                                                                 //bakiye yetersiz uyarısı için
                {
                    SellPopup.SetActive(true);
                }

            }
            if (PlayerPrefs.GetString("Sell", "") == "buyrabbit")                              //eğer alınmışsa karakter buy butonunu kapat seçme butonunu aç ve hep böyle kalsın bir kere alma işlemi gerçekleştiği için.
            {
                Sellbutton.SetActive(false);
                Selectbutton.SetActive(true);

            }

        }
        if (NameItem.GetComponent<Text>().text == "Monkey")
        {


            if (!(PlayerPrefs.GetString("Sell", "") == "buymonkey"))                          //karakter alınmadıysa
            {
                Coin = StartsEmerald.transform.GetComponent<Coin>().toplamCoin;
                if (Coin >= 4000)
                {
                    PlayerPrefs.SetString("Sell", "buymonkey");                                    //alındığını kaydetti
                    PlayerPrefs.SetInt("totalcoin", PlayerPrefs.GetInt("totalcoin", 0) - 4000);      //parayı azalt ve kaydet
                    StartsEmerald.transform.GetComponent<Coin>().Settext();                          //azaltılan parayı texte yazdırması için coinden Settex metodu çek
                }
                    if (Coin < 4000)                                                                 //bakiye yetersiz uyarısı için
                {
                    SellPopup.SetActive(true);
                }

            }
            if (PlayerPrefs.GetString("Sell", "") == "buymonkey")                              //eğer alınmışsa karakter buy butonunu kapat seçme butonunu aç ve hep böyle kalsın bir kere alma işlemi gerçekleştiği için.
            {
                Sellbutton.SetActive(false);
                Selectbutton.SetActive(true);

            }

        }
        if (NameItem.GetComponent<Text>().text == "Tigger")
        {


            if (!(PlayerPrefs.GetString("Sell", "") == "buytigger"))                          //karakter alınmadıysa
            {
                Coin = StartsEmerald.transform.GetComponent<Coin>().toplamCoin;
                if (Coin >= 5000)
                {
                    
                    PlayerPrefs.SetString("Sell", "buytigger");                                    //alındığını kaydetti
                    PlayerPrefs.SetInt("totalcoin", PlayerPrefs.GetInt("totalcoin", 0) - 5000);      //parayı azalt ve kaydet
                    StartsEmerald.transform.GetComponent<Coin>().Settext();                          //azaltılan parayı texte yazdırması için coinden Settex metodu çek
                }
                if (Coin < 5000)                                                                 //bakiye yetersiz uyarısı için
                {
                    SellPopup.SetActive(true);
                }

            }
            if (PlayerPrefs.GetString("Sell", "") == "buytigger")                              //eğer alınmışsa karakter buy butonunu kapat seçme butonunu aç ve hep böyle kalsın bir kere alma işlemi gerçekleştiği için.(aldıktan sonra anında buton hareketlerini görelim diye yapıldı)
            {
                Sellbutton.SetActive(false);
                Selectbutton.SetActive(true);

            }

        }

        if (NameItem.GetComponent<Text>().text == "Wooden Sled")
        {


            if (!(PlayerPrefs.GetString("Sell", "") == "buywoodensled"))                          //karakter alınmadıysa
            {

                Coin = StartsEmerald.transform.GetComponent<Coin>().toplamCoin;
                if (Coin >= 1000)
                {
                    PlayerPrefs.SetString("Sell", "buywoodensled");                                    //alındığını kaydetti
                    PlayerPrefs.SetInt("totalcoin", PlayerPrefs.GetInt("totalcoin", 0) - 1000);      //parayı azalt ve kaydet
                    StartsEmerald.transform.GetComponent<Coin>().Settext();                          //azaltılan parayı texte yazdırması için coinden Settex metodu çek
                }
                if (Coin < 1000)                                                                 //bakiye yetersiz uyarısı için
                {
                    SellPopup.SetActive(true);
                }

            }
            if (PlayerPrefs.GetString("Sell", "") == "buywoodensled")                              //eğer alınmışsa karakter buy butonunu kapat seçme butonunu aç ve hep böyle kalsın bir kere alma işlemi gerçekleştiği için.(aldıktan sonra anında buton hareketlerini görelim diye yapıldı)
            {
                Sellbutton.SetActive(false);
                Selectbutton.SetActive(true);
            }

        }
        if (NameItem.GetComponent<Text>().text == "Red Sled")
        {

            if (!(PlayerPrefs.GetString("Sell", "") == "buyredsled"))                          //karakter alınmadıysa
            {
                Coin = StartsEmerald.transform.GetComponent<Coin>().toplamCoin;
                if (Coin >= 3000)
                {
                    PlayerPrefs.SetString("Sell", "buyredsled");                                    //alındığını kaydetti
                    PlayerPrefs.SetInt("totalcoin", PlayerPrefs.GetInt("totalcoin", 0) - 3000);      //parayı azalt ve kaydet
                    StartsEmerald.transform.GetComponent<Coin>().Settext();                          //azaltılan parayı texte yazdırması için coinden Settex metodu çek
                }
                if (Coin < 3000)                                                                 //bakiye yetersiz uyarısı için
                {
                    SellPopup.SetActive(true);
                }

            }
            if (PlayerPrefs.GetString("Sell", "") == "buyredsled")                              //eğer alınmışsa karakter buy butonunu kapat seçme butonunu aç ve hep böyle kalsın bir kere alma işlemi gerçekleştiği için.(aldıktan sonra anında buton hareketlerini görelim diye yapıldı)
            {
                Sellbutton.SetActive(false);
                Selectbutton.SetActive(true);

            }

        }
        if (NameItem.GetComponent<Text>().text == "Blue Sled")
        {


            if (!(PlayerPrefs.GetString("Sell", "") == "buybluesled"))                          //karakter alınmadıysa
            {

                Coin = StartsEmerald.transform.GetComponent<Coin>().toplamCoin;
                if (Coin >= 2000)
                {
                    PlayerPrefs.SetString("Sell", "buybluesled");                                    //alındığını kaydetti
                    PlayerPrefs.SetInt("totalcoin", PlayerPrefs.GetInt("totalcoin", 0) - 2000);      //parayı azalt ve kaydet
                    StartsEmerald.transform.GetComponent<Coin>().Settext();                          //azaltılan parayı texte yazdırması için coinden Settex metodu çek
                }
                if (Coin < 2000)                                                                 //bakiye yetersiz uyarısı için
                {
                    SellPopup.SetActive(true);
                }

            }
            if (PlayerPrefs.GetString("Sell", "") == "buybluesled")                              //eğer alınmışsa karakter buy butonunu kapat seçme butonunu aç ve hep böyle kalsın bir kere alma işlemi gerçekleştiği için.(aldıktan sonra anında buton hareketlerini görelim diye yapıldı)
            {
                Sellbutton.SetActive(false);
                Selectbutton.SetActive(true);

            }

        }
        if (NameItem.GetComponent<Text>().text == "Snow Monster")
        {


            if (!(PlayerPrefs.GetString("Sell", "") == "buysnowmonstersled"))                          //karakter alınmadıysa
            {
                Coin = StartsEmerald.transform.GetComponent<Coin>().toplamCoin;
                if (Coin >= 4000)
                {
                    PlayerPrefs.SetString("Sell", "buysnowmonstersled");                                    //alındığını kaydetti
                    PlayerPrefs.SetInt("totalcoin", PlayerPrefs.GetInt("totalcoin", 0) - 4000);      //parayı azalt ve kaydet
                    StartsEmerald.transform.GetComponent<Coin>().Settext();                          //azaltılan parayı texte yazdırması için coinden Settex metodu çek
                }
                if (Coin < 4000)                                                                 //bakiye yetersiz uyarısı için
                {
                    SellPopup.SetActive(true);
                }

            }
            if (PlayerPrefs.GetString("Sell", "") == "buysnowmonstersled")                              //eğer alınmışsa karakter buy butonunu kapat seçme butonunu aç ve hep böyle kalsın bir kere alma işlemi gerçekleştiği için.(aldıktan sonra anında buton hareketlerini görelim diye yapıldı)
            {
                Sellbutton.SetActive(false);
                Selectbutton.SetActive(true);

            }

        }
        if (NameItem.GetComponent<Text>().text == "Super Sled")
        {


            if (!(PlayerPrefs.GetString("Sell", "") == "buysupersled"))                          //karakter alınmadıysa
            {
                Coin = StartsEmerald.transform.GetComponent<Coin>().toplamCoin;
                if (Coin >= 5000)
                {
                    PlayerPrefs.SetString("Sell", "buysupersled");                                    //alındığını kaydetti
                    PlayerPrefs.SetInt("totalcoin", PlayerPrefs.GetInt("totalcoin", 0) - 5000);      //parayı azalt ve kaydet
                    StartsEmerald.transform.GetComponent<Coin>().Settext();                          //azaltılan parayı texte yazdırması için coinden Settex metodu çek
                }
                if (Coin < 5000)                                                                 //bakiye yetersiz uyarısı için
                {
                    SellPopup.SetActive(true);
                }

            }
            if (PlayerPrefs.GetString("Sell", "") == "buysupersled")                              //eğer alınmışsa karakter buy butonunu kapat seçme butonunu aç ve hep böyle kalsın bir kere alma işlemi gerçekleştiği için.(aldıktan sonra anında buton hareketlerini görelim diye yapıldı)
            {
                Sellbutton.SetActive(false);
                Selectbutton.SetActive(true);

            }

        }

        if (NameItem.GetComponent<Text>().text == "Emerald I")
        {
   
                    PlayerPrefs.SetInt("totalcoin", PlayerPrefs.GetInt("totalcoin", 0) + 2000);      //parayı arttır ve kaydet
                    StartsEmerald.transform.GetComponent<Coin>().Settext();                          //arttırılan parayı texte yazdırması için coinden Settex metodu çek

           
                Selectbutton.SetActive(false);
        }
        if (NameItem.GetComponent<Text>().text == "Emerald II")
        {

            PlayerPrefs.SetInt("totalcoin", PlayerPrefs.GetInt("totalcoin", 0) + 4000);      //parayı arttır ve kaydet
            StartsEmerald.transform.GetComponent<Coin>().Settext();                          //arttırılan parayı texte yazdırması için coinden Settex metodu çek


            Selectbutton.SetActive(false);
        }
        if (NameItem.GetComponent<Text>().text == "Emerald III")
        {

            PlayerPrefs.SetInt("totalcoin", PlayerPrefs.GetInt("totalcoin", 0) + 6000);      //parayı azalt ve kaydet
            StartsEmerald.transform.GetComponent<Coin>().Settext();                          //azaltılan parayı texte yazdırması için coinden Settex metodu çek


            Selectbutton.SetActive(false);
        }
        if (NameItem.GetComponent<Text>().text == "Emerald IV")
        {

            PlayerPrefs.SetInt("totalcoin", PlayerPrefs.GetInt("totalcoin", 0) + 8000);      //parayı azalt ve kaydet
            StartsEmerald.transform.GetComponent<Coin>().Settext();                          //azaltılan parayı texte yazdırması için coinden Settex metodu çek


            Selectbutton.SetActive(false);
        }
    }
    
    public void SelecButton()
    {
       

        if (NameItem.GetComponent<Text>().text =="Penguin" )                                    //Penguin seçildiyse seçildi popupu açılsın ve datada seçileni tutsun playerı değiştirebilmek için
        {
           
            SelectPopup.SetActive(true);
            PopupText.text = "The penguin is selected";

            PlayerPrefs.SetString("CharacterChoose","Penguin");
           
        }


        if (NameItem.GetComponent<Text>().text == "Panda") 
        {
            SelectPopup.SetActive(true);
            PopupText.text = "The panda is selected";

            PlayerPrefs.SetString("CharacterChoose", "Panda");

        }

        if (NameItem.GetComponent<Text>().text == "Pig")
        {
            SelectPopup.SetActive(true);
            PopupText.text = "The pig is selected";

            PlayerPrefs.SetString("CharacterChoose", "Pig");

        }

        if (NameItem.GetComponent<Text>().text == "Rabbit")
        {
            SelectPopup.SetActive(true);
            PopupText.text = "The rabbit is selected";

            PlayerPrefs.SetString("CharacterChoose", "Rabbit");

        }

        if (NameItem.GetComponent<Text>().text == "Monkey")
        {
            SelectPopup.SetActive(true);
            PopupText.text = "The monkey is selected";

            PlayerPrefs.SetString("CharacterChoose", "Monkey");

        }

        if (NameItem.GetComponent<Text>().text == "Tigger")
        {
            SelectPopup.SetActive(true);
            PopupText.text = "The tigger is selected";

            PlayerPrefs.SetString("CharacterChoose", "Tigger");

        }
        if (NameItem.GetComponent<Text>().text == "Elephand")
        {
            SelectPopup.SetActive(true);
            PopupText.text = "The elephand is selected";

            PlayerPrefs.SetString("CharacterChoose", "Elephand");

        }

        //sledler için data tutuyoruz...
        if (NameItem.GetComponent<Text>().text == "Brown Sled")
        {
            SelectPopup.SetActive(true);
            PopupText.text = "Brown Sled is selected";

            PlayerPrefs.SetString("SledChoose", "Brown Sled");


        }
        if (NameItem.GetComponent<Text>().text == "Wooden Sled")
        {
            SelectPopup.SetActive(true);
            PopupText.text = "Wooden Sled is selected";

            PlayerPrefs.SetString("SledChoose", "Wooden Sled");


        }
        if (NameItem.GetComponent<Text>().text == "Red Sled")
        {
            SelectPopup.SetActive(true);
            PopupText.text = "Red Sled is selected";

            PlayerPrefs.SetString("SledChoose", "Red Sled");


        }
        if (NameItem.GetComponent<Text>().text == "Blue Sled")
        {
            SelectPopup.SetActive(true);
            PopupText.text = "Blue Sled is selected";

            PlayerPrefs.SetString("SledChoose", "Blue Sled");


        }
        if (NameItem.GetComponent<Text>().text == "Snow Monster")
        {
            SelectPopup.SetActive(true);
            PopupText.text = "Snow Monster is selected";

            PlayerPrefs.SetString("SledChoose", "Snow Monster");


        }
        if (NameItem.GetComponent<Text>().text == "Super Sled")
        {
            SelectPopup.SetActive(true);
            PopupText.text = "Super Sled is selected";

            PlayerPrefs.SetString("SledChoose", "Super Sled");


        }


    }
}
