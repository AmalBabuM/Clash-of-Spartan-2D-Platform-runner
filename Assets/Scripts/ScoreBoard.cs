using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    public TextMeshProUGUI scoreValue;
    public static int score = 0;
    /*1 SaveSystem saving;*/
    private void Start()
    {
       /* 1 saving= new SaveSystem();*/
    }

    public void ScoreUpdate()
    {
        score++;
        /*Debug.Log(point);*/
        /*Debug.Log(point.ToString());*/
        scoreValue.text = "Score : " + score.ToString();

        /*1 saving.SaveData(score);*/

    }

    public void ResumeGame(int value)
    {
        score = value;
        Debug.Log(score);
        scoreValue.text = "Score : " + score.ToString();
    }
   
}
