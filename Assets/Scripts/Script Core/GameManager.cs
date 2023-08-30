using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour
{
    public GameObject[] button;
    public int id;
    public int selectedID;
    
    [Serializable]
    public class UpdateIsi
    {
        public Sprite[] imgBisindo;
        public Image bisindoImage;
        public void UpdateUI(Sprite bisindo)
        {

            bisindoImage.sprite = bisindo;
        }

    }

    public UpdateIsi uiCharacter;

    private void Start()
    {
        DataButton tempData = button[id].GetComponent<DataButton>();
        uiCharacter.UpdateUI(tempData.imgBisindo[selectedID]);
    }

    public void NextButton()
    {
        if (selectedID == 25)
        {
            Debug.Log("Habis Bro");
        }
        else
        {
            selectedID+=1;
            DataButton tempData = button[id].GetComponent<DataButton>();
            uiCharacter.UpdateUI(tempData.imgBisindo[selectedID]);
            Debug.Log("aada"); 

        }


    }

    public void PrevButton()
    {
        if (selectedID == 0)
        {
            Debug.Log("Habis Bro");
        }
        else
        {
            selectedID-=1;


            DataButton tempData = button[id].GetComponent<DataButton>();
            uiCharacter.UpdateUI(tempData.imgBisindo[selectedID]);

        }
        
    }
    


}
