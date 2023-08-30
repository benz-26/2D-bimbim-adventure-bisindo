using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataPanel : MonoBehaviour
{
    public int id;
    public int selectedID;
    public Sprite[] imgInstrc;
    public Image instrcImg;

    public void UpdateUI(Sprite instrc)
    {

        instrcImg.sprite = instrc;
    }

}
