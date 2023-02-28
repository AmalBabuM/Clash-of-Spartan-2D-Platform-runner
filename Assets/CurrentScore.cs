using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CurrentScore : MonoBehaviour
{
    TextMeshProUGUI score;
    void Start()
    {
        score= GetComponent<TextMeshProUGUI>();

        score.text="Score : "+PlayerPrefs.GetInt("Score").ToString();
    }

   
}
