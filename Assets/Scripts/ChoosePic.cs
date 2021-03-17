using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChoosePic : MonoBehaviour
{
    public GameObject ChangeImage;
    
    Image item;
    public GameObject NameItem;
    public GameObject Sellbutton;
    public Text SellPriceText;
    public GameObject Selectbutton;

    public void ChooseCharacters() // herhangi bir karaktere tıklandığında 
    {
        
        item =transform.GetChild(0).GetChild(0).GetComponent<Image>();                                                  //tıklanan karakterin resimini al item e ata
       ChangeImage.GetComponent<Image>().sprite=item.sprite;                                                            //İtemı sağ taraftaki seçilen resme ata  

        NameItem.GetComponent<Text>().text = transform.name;                                                            //Hangisi karakteri seçtiyse onun Hierarchy 'deki ismini sağ taraftaki isim bölümüne yaz.

        if (NameItem.GetComponent<Text>().text == "Penguin" || NameItem.GetComponent<Text>().text =="Brown Sled" )      //ana karakterler olan penguin ve sled seçildiğinde  Sell buton gizlensin
        {
            Sellbutton.SetActive(false);
            Selectbutton.SetActive(true);
        }
       else
        {
            Sellbutton.SetActive(true);
        }

    //------------------------------------------------------------------------------------------------------------------------------

        if (NameItem.GetComponent<Text>().text == "Elephand")                                                            //isimlere göre fiyat listesi
        {
            SellPriceText.text = "1000";

            if (PlayerPrefs.GetString("Sell", "") == "buyelephand") //butona basılmadığı zaman da sadece karaktere tıklayınca da eğer alınmışsa karakter selli kapat selecti aç diğer durumlarda da selec kapalı olsun
            {
                Sellbutton.SetActive(false);
                Selectbutton.SetActive(true);

            }
            else
            {
                Selectbutton.SetActive(false);
            }

        }
        if (NameItem.GetComponent<Text>().text == "Rabbit")
        {
            SellPriceText.text = "2000";
            if (PlayerPrefs.GetString("Sell", "") == "buyrabbit") //butona basılmadığı zaman da sadece karaktere tıklayınca da eğer alınmışsa karakter selli kapat selecti aç diğer durumlarda da selec kapalı olsun
            {
                Sellbutton.SetActive(false);
                Selectbutton.SetActive(true);

            }
            else
            {
                Selectbutton.SetActive(false);
            }


        }
        if (NameItem.GetComponent<Text>().text == "Pig")
        {
            SellPriceText.text = "3000";

            if (PlayerPrefs.GetString("Sell", "") == "buypig")
            {
                Sellbutton.SetActive(false);
                Selectbutton.SetActive(true);

            }
            else
            {
                Selectbutton.SetActive(false);
            }

        }
        if (NameItem.GetComponent<Text>().text == "Monkey")
        {
            SellPriceText.text = "4000";
            if (PlayerPrefs.GetString("Sell", "") == "buymonkey") //butona basılmadığı zaman da sadece karaktere tıklayınca da eğer alınmışsa karakter selli kapat selecti aç diğer durumlarda da selec kapalı olsun
            {
                Sellbutton.SetActive(false);
                Selectbutton.SetActive(true);

            }
            else
            {
                Selectbutton.SetActive(false);
            }

        }
        if (NameItem.GetComponent<Text>().text == "Tigger")
        {
            SellPriceText.text = "5000";
            if (PlayerPrefs.GetString("Sell", "") == "buytigger") //butona basılmadığı zaman da sadece karaktere tıklayınca da eğer alınmışsa karakter selli kapat selecti aç diğer durumlarda da selec kapalı olsun
            {
                Sellbutton.SetActive(false);
                Selectbutton.SetActive(true);

            }
            else
            {
                Selectbutton.SetActive(false);
            }


        }
        if (NameItem.GetComponent<Text>().text == "Panda")
        {
            SellPriceText.text = "6000";

            if (PlayerPrefs.GetString("Sell", "") == "buypanda")
            {
                Sellbutton.SetActive(false);
                Selectbutton.SetActive(true);

            }
            else
            {
                Selectbutton.SetActive(false);
            }
        }

    }
    public void ChooseSleds()       //karakterler için olan açıklamalar geçerli
    {
       
        item = transform.GetChild(0).GetChild(0).GetComponent<Image>();
        ChangeImage.GetComponent<Image>().sprite = item.sprite;
        NameItem.GetComponent<Text>().text = transform.name;

        if (NameItem.GetComponent<Text>().text == "Penguin" || NameItem.GetComponent<Text>().text == "Brown Sled") //bu karakterler satın alınmaması gerekiyor
        {
            Sellbutton.SetActive(false);
            Selectbutton.SetActive(true);
        }
        else
        {
            Sellbutton.SetActive(true);
        }

    //------------------------------------------------------------------------------------------------------------------------------

        if (NameItem.GetComponent<Text>().text == "Wooden Sled")
        {
            SellPriceText.text = "1000";
            if (PlayerPrefs.GetString("Sell", "") == "buywoodensled")
            {
                Sellbutton.SetActive(false);
                Selectbutton.SetActive(true);

            }
            else
            {
                Selectbutton.SetActive(false);
            }
        }
        if (NameItem.GetComponent<Text>().text == "Blue Sled")
        {
            SellPriceText.text = "2000";
            if (PlayerPrefs.GetString("Sell", "") == "buybluesled")
            {
                Sellbutton.SetActive(false);
                Selectbutton.SetActive(true);

            }
            else
            {
                Selectbutton.SetActive(false);
            }
        }
        if (NameItem.GetComponent<Text>().text == "Red Sled")
        {
            SellPriceText.text = "3000";
            if (PlayerPrefs.GetString("Sell", "") == "buyredsled")
            {
                Sellbutton.SetActive(false);
                Selectbutton.SetActive(true);

            }
            else
            {
                Selectbutton.SetActive(false);
            }
        }
        if (NameItem.GetComponent<Text>().text == "Snow Monster")
        {
            SellPriceText.text = "4000";
            if (PlayerPrefs.GetString("Sell", "") == "buysnowmonstersled")
            {
                Sellbutton.SetActive(false);
                Selectbutton.SetActive(true);

            }
            else
            {
                Selectbutton.SetActive(false);
            }
        }
        if (NameItem.GetComponent<Text>().text == "Super Sled")
        {
            SellPriceText.text = "5000";
            if (PlayerPrefs.GetString("Sell", "") == "buysupersled")
            {
                Sellbutton.SetActive(false);
                Selectbutton.SetActive(true);

            }
            else
            {
                Selectbutton.SetActive(false);
            }
        }      

    }
    public void ChooseEmerals()          //karakterler için olan açıklamalar geçerli
    {

        item = transform.GetChild(0).GetChild(0).GetComponent<Image>();
        ChangeImage.GetComponent<Image>().sprite = item.sprite;
        NameItem.GetComponent<Text>().text = transform.name;

        if (NameItem.GetComponent<Text>().text == "Emerald I" || NameItem.GetComponent<Text>().text == "Emerald II" || NameItem.GetComponent<Text>().text == "Emerald III" || NameItem.GetComponent<Text>().text == "Emerald IV")  //emeraldlara tıklanınca select button olmasın 
        {
            Selectbutton.SetActive(false);       
        }
    //------------------------------------------------------------------------------------------------------------------------------

        if (NameItem.GetComponent<Text>().text == "Emerald I")
        {
            SellPriceText.text = "2000";
        }
        if (NameItem.GetComponent<Text>().text == "Emerald II")
        {
            SellPriceText.text = "4000";
        }
        if (NameItem.GetComponent<Text>().text == "Emerald III")
        {
            SellPriceText.text = "6000";
        }
        if (NameItem.GetComponent<Text>().text == "Emerald IV")
        {
            SellPriceText.text = "8000";
        }
    }
}
