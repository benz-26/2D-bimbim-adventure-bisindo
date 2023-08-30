using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueNPCPopUp : MonoBehaviour
{

    public GameObject alertCanvas;
    public GameObject npcDialogueCanvas;
    public GameObject dialogueAlert;

    private void awake()
    {
        dialogueAlert.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        alertCanvas.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        alertCanvas.SetActive(false);
    }

    public void CloseButton()
    {
        Time.timeScale = 1;
        alertCanvas.SetActive(false);
        npcDialogueCanvas.SetActive(false);
    }

    public void ShowDialogue()
    {
        Time.timeScale = 0;
        npcDialogueCanvas.SetActive(true);
    }






}
