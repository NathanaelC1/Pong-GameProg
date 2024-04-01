using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int ScoreP1;
    public int ScoreP2;
    public TMP_Text uIScoreP1;
    public TMP_Text uIScoreP2;
    public TMP_Text uIWinTextCond;
    public GameObject uIWinLose;
    public SceneManagement sceneManagement;

    public static GameManager instance;

    public void Awake()
    {
        if(instance == null) instance = this;
        else Destroy(gameObject);
    }

    public void Score(string SideWallName)
    {
        if(SideWallName == "SideWallP1")
        {
            ScoreP2 += 10;
            uIScoreP2.text = ScoreP2.ToString();
            ScoreCheck();
        } 
        else
        {
            ScoreP1 += 10;
            uIScoreP1.text = ScoreP1.ToString();
            ScoreCheck();
        } 
    }

    void Delay()
    {
        sceneManagement.ChangeScene("MenuScene");
    }

    private void ScoreCheck()
    {
        if(ScoreP1 == 20)
        {
            uIWinLose.SetActive(true);
            uIWinTextCond.text = "P1 WIN!";
            Invoke("Delay", 2.0f);
        }
        else if(ScoreP2 == 20)
        {           
            uIWinLose.SetActive(true);
            uIWinTextCond.text = "P2 WIN!";
            Invoke("Delay", 2.0f);
        }
    }

}
