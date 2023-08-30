using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour
{
    public static QuestManager instance;

    public GameObject finishedCanvas;
    public GameObject pauseCanvas;
    public TextMeshProUGUI questProgress;

    public int currentProgress = 0;
    public int maxProgress = 10;

    private void Awake()
    {
        instance = this;
    }


    private void Update()
    {
        questProgress.text = currentProgress.ToString() + " / 10";
        FinishedGame();
    }

    #region Panel Canvas


    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseCanvas.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseCanvas.SetActive(false);
    }

    public void HomeScreen(int scene)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(scene);
    }
    #endregion

    public void AddPoint(int RightAmount)
    {
        currentProgress += RightAmount;
        if (currentProgress > maxProgress)
        {
            currentProgress = maxProgress;
        }
    }


    public void FinishedGame()
    {
        if (currentProgress == 10)
        {
            finishedCanvas.SetActive(true);
        }
    }

    public void CloseFnshCvs()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main Menu");
        currentProgress = 0;
    }



}
