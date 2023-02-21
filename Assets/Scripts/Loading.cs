using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static SaveSystem;

public class Loading : MonoBehaviour
{
    SaveSystem saveSystem;
    ScoreBoard board;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        saveSystem = new SaveSystem();
        board =FindObjectOfType<ScoreBoard>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("l"))
        {
            Debug.Log("JJ");
            SaveDataObject obj = saveSystem.LoadGame();

            score = obj.score;
            board.ResumeGame(score);


        }
    }
}
