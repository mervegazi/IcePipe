using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupButtons : MonoBehaviour
{
    public GameObject SelectPopup;
    public GameObject SellPopup;
    public void OkButton()
    {
        SelectPopup.SetActive(false); 
    }
    public void CloseButton()
    {
        SelectPopup.SetActive(false);   
    }
    public void okbuttonsell()
    {
        SellPopup.SetActive(false);
    }
    public void closebuttonsell()
    {
        SellPopup.SetActive(false);
    }
}
