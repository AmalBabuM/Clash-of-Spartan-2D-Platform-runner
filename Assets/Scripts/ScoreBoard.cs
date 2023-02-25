using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreBoard : MonoBehaviour
{
    /*public TextMeshProUGUI scoreValue;*/
    /*public */TextMeshProUGUI scoreValue;
    public static int score;
    Player player;
    int currentScore=0;
    /*1 SaveSystem saving;*/
    private void Start()
    {   
        scoreValue= GetComponent<TextMeshProUGUI>();
        player=FindObjectOfType<Player>();
        StartDisplay();

        if(SceneManager.GetActiveScene().buildIndex==1)
        {
            currentScore = 0;
        }
        else
        {
            currentScore = PlayerPrefs.GetInt("Score", 0);
        }
        Debug.Log("restarted score : " + currentScore);


       /* 1 saving= new SaveSystem();*/
    }

    public void StartDisplay()
    {
        scoreValue.text = "Score : " + score.ToString();
    }

    public void ScoreUpdate()
    {
        score++;
        currentScore++;
        /*Debug.Log(point);*/
        /*Debug.Log(point.ToString());*/
        scoreValue.text = "Score : " + score.ToString();
        player.ScoreUpdate(score);

        Debug.Log(currentScore);

        /*1 saving.SaveData(score);*/

    }

    public void FlagSave()
    {
        PlayerPrefs.SetInt("Score",currentScore);
        Debug.Log("Saved Score : "+ currentScore);
    }

    public void LoadScore(int value)
    {
        score = value;
        Debug.Log(score);
        scoreValue.text = "Score : " + score.ToString();
    }

}
