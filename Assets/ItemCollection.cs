using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollection : MonoBehaviour
{
    ScoreBoard sc;
    int score = 0;
    private void Start()
    {
        sc = GameObject.Find("GameManager").GetComponent<ScoreBoard>(); // we can do t his or directly assign making the variable public
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Eatable")
        {
            score++;
            sc.ScoreUpdate(score);

            Destroy(collision.gameObject);
            /*Debug.Log("Heyyy");*/

           /* Debug.Log(score);*/
        }

    }

}
