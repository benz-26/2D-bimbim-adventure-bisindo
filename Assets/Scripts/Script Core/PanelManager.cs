using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PanelManager : MonoBehaviour
{


    public GameObject infoCanvas;
    public GameObject[] button;

    public int ID;
    public int IDSelected;

    [Serializable]
    public class UpdateIsih
    {
        public Sprite[] imgInstrc;
        public Image instrcImg;

        public void UpdateUIH(Sprite instrc)
        {

            instrcImg.sprite = instrc;
        }

    }



    public UpdateIsih uiCharacter;

    private void Start()
    {
        DataPanel tempData = button[ID].GetComponent<DataPanel>();
        uiCharacter.UpdateUIH(tempData.imgInstrc[IDSelected]);
    }

    public void NextButton()
    {
        if (IDSelected == 8)
        {
            Debug.Log("Habis Bro");
        }
        else
        {
            IDSelected ++;

            DataPanel tempData = button[ID].GetComponent<DataPanel>();
            uiCharacter.UpdateUIH(tempData.imgInstrc[IDSelected]);
            Debug.Log("aada");

        }


    }

    public void PrevButton()
    {
        if (IDSelected == 0)
        {
            Debug.Log("Habis Bro");
        }
        else
        {
            IDSelected --;

            DataPanel tempData = button[ID].GetComponent<DataPanel>();
            uiCharacter.UpdateUIH(tempData.imgInstrc[IDSelected]);

        }

    }

    public void InfoPopUp()
    {
        Time.timeScale = 0;
        infoCanvas.SetActive(true);
        Debug.Log("Aktif");

    }



    public void InfoPopDown()
    {
        Time.timeScale = 1;
        infoCanvas.SetActive(false);
        IDSelected = 0;

    }





}
