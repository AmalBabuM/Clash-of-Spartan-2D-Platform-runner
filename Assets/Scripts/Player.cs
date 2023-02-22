using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int scene = 0;
    public int score = 2;
    public int health = 20;

    HealthBar healthBar;
    ScoreBoard scoreBoard;

    Rigidbody2D rb;
    private void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        healthBar=FindObjectOfType<HealthBar>();
        scoreBoard=FindObjectOfType<ScoreBoard>();
        /*healthBar=FindObjectOfType<HealthBar>();*/
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))

        {
            scene = SceneManager.GetActiveScene().buildIndex;
            Debug.Log("Current Scene No."+ scene);

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
   
    public void SavePlayer()
    {
        scene = SceneManager.GetActiveScene().buildIndex;
        Debug.Log("Hi");
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        SceneManager.LoadScene(data.scene);
        Debug.Log("Hi all");
        healthBar.LoadHealth(data.health);
        scoreBoard.LoadScore(data.score);

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];

        transform.position= position;

    }
}
