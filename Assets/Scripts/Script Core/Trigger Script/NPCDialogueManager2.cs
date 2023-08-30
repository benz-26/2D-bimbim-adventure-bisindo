using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NPCDialogueManager2 : MonoBehaviour
{
    public GameObject alertCanvas;
    public GameObject dialogueAlert;
    public GameObject QuizCanvas;
    public GameObject RightCanvas;
    public GameObject WrongCanvas;

    private void OnTriggerEnter2D(Collider2D collision)
    { 
    
        alertCanvas.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        alertCanvas.SetActive(false);
    }

    public void QuizGame()
    {
        QuizCanvas.SetActive(true);
    }

    public void CloseQuizGame()
    {
        QuizCanvas.SetActive(false);
        RightCanvas.SetActive(false);
        WrongCanvas.SetActive(false);

    }

}
