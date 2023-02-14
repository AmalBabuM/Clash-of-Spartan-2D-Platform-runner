using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    public TextMeshProUGUI score;
    
    
    public void ScoreUpdate(int point)
    {
        score.text = "Score : " + point.ToString();
    }
   
}
