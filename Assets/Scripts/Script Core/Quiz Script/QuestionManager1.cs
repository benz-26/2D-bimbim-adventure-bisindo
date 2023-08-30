using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class QuestionManager1 : MonoBehaviour
{
    public GameObject question;
    public TextMeshProUGUI[] answers;
    public GameObject questionImage;
    public GameObject rightAsnwerPanel;
    public GameObject wrongAsnwerPanel;

    public int IDCorrectAns;
    public int answerID;
    public string[] answerText;
    public string questionText;
    public float questionAdd = 1f;
    public int addAmount = 1;
    #region boolean
    /*
        public bool completedQuest = false;
        public bool completedQuest1 = false;
        public bool completedQuest2 = false;
        public bool completedQuest3 = false;
        public bool completedQuest4 = false;
        public bool completedQuest5 = false;
        public bool completedQuest6 = false;
        public bool completedQuest7 = false;
        public bool completedQuest8 = false;
        public bool completedQuest9 = false;*/
    #endregion


    public void Start()
    {
        LoadQuestions();
    }


    public void Update()
    {

    }


    public void LoadQuestions()
    {
        question.GetComponent<TextMeshProUGUI>().text = questionText;

        for (int i = 0; i < answers.Length; i++)
        {
            answers[i].text = answerText[i];
        }
    }

    public void QuestionCheck(int id)
    {
        if (IDCorrectAns == id)
        {
            rightAsnwerPanel.SetActive(true);
            QuestManager.instance.AddPoint(addAmount);
            Debug.Log("tambah");
        }
        else if (IDCorrectAns != id)
        {
            wrongAsnwerPanel.SetActive(true);
        }
    }

}
