using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    /*public TextMeshProUGUI scoreValue;*/
    /*public */TextMeshProUGUI scoreValue;
    public int score = 0;
    Player player;
    /*1 SaveSystem saving;*/
    private void Start()
    {   
        scoreValue= GetComponent<TextMeshProUGUI>();
        player=FindObjectOfType<Player>();

       /* 1 saving= new SaveSystem();*/
    }

    public void ScoreUpdate()
    {
        score++;
        /*Debug.Log(point);*/
        /*Debug.Log(point.ToString());*/
        scoreValue.text = "Score : " + score.ToString();
        player.ScoreUpdate(score);

        /*1 saving.SaveData(score);*/

    }

    public void LoadScore(int value)
    {
        score = value;
        Debug.Log(score);
        scoreValue.text = "Score : " + score.ToString();
    }

}
