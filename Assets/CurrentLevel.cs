using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CurrentLevel : MonoBehaviour
{
    TextMeshProUGUI level;
    // Start is called before the first frame update
    void Start()
    {
        level= GetComponent<TextMeshProUGUI>();
        level.text=SceneManager.GetActiveScene().buildIndex.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
