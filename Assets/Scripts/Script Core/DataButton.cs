using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DataButton : MonoBehaviour
{
    public int id;
    public int selectedID;
    public Sprite[] imgBisindo;
    public Image bisindoImage;    

    public void UpdateUI(Sprite bisindo)
    {

        bisindoImage.sprite = bisindo;
    }


}
