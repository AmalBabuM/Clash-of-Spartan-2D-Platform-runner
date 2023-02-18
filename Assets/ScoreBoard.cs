using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    public TextMeshProUGUI score;

    SaveSystem saving;
    private void Start()
    {
        saving= new SaveSystem();
    }

    public void ScoreUpdate(int point)
    {
        /*Debug.Log(point);*/
        Debug.Log(point.ToString());
        score.text = "Score : " + point.ToString();

        saving.SaveData(point);

    }
   
}
