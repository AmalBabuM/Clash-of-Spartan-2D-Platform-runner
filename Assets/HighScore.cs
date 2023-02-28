using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    TextMeshProUGUI score;
    void Start()
    {
        score = GetComponent<TextMeshProUGUI>();

        score.text = "H Score: " + PlayerPrefs.GetInt("HighScore").ToString();
    }
}
