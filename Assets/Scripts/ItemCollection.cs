using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static SaveSystem;

public class ItemCollection : MonoBehaviour
{
    ScoreBoard sc;
    AudioManager audioManager;
    /*static int score = 0;*/
    /*SaveSystem saveSystem;*/
    private void Start()
    {   
        audioManager=FindObjectOfType<AudioManager>();
        /*saveSystem= new SaveSystem();*/
       /* sc = GameObject.Find("GameManager").GetComponent<ScoreBoard>();*/ // we can do t his or directly assign making the variable public
        sc= FindObjectOfType<ScoreBoard>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Eatable")
        {
            audioManager.CoinCollect();
            /*score++;*/
            sc.ScoreUpdate();

            Destroy(collision.gameObject);
            /*Debug.Log("Heyyy");*/

           /* Debug.Log(score);*/
        }

    }
    /*private void Update()
    {
        if (Input.GetKeyDown("l"))
        {
            Debug.Log("JJ");
            SaveDataObject obj = saveSystem.LoadGame();

            score = obj.score;

            sc.ScoreUpdate(score);

        }
    }*/

}
