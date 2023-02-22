using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int scene = 1;
    public int score = 2;
    public int health = 10;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))

        {
            scene=SceneManager.GetActiveScene().buildIndex;

            Saveplayer();
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
   
    void Saveplayer()
    {
        Debug.Log("Hi");
        SaveSystem.SavePlayer(this);
    }
}
