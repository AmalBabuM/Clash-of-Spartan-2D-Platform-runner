using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int scene = 1;
    public int score = 2;
    public int health = 10;

    HealthBar healthBar;
    ScoreBoard scoreBoard;
    private void Start()
    {
        healthBar=FindObjectOfType<HealthBar>();
        scoreBoard=FindObjectOfType<ScoreBoard>();
        /*healthBar=FindObjectOfType<HealthBar>();*/
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))

        {
            scene=SceneManager.GetActiveScene().buildIndex;

            SavePlayer();
        }

        if(Input.GetKeyDown(KeyCode.V))
        {
            LoadPlayer();
        }
    }

    public void ScoreUpdate(int value)
    {
        score= value;
    }
    public void HealthUpdate(int value)
    {
        health = value;
    }
   
    void SavePlayer()
    {
        Debug.Log("Hi");
        SaveSystem.SavePlayer(this);
    }

    void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        Debug.Log("Hi all");
        healthBar.SetValue(data.health);
        scoreBoard.LoadScore(data.score);

    }
}
