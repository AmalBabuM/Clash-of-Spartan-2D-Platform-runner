using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    Rigidbody rb;
    ScoreBoard sc;
    private void Start()
    {
        sc=FindObjectOfType<ScoreBoard>();
        rb= GetComponent<Rigidbody>();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Flag")
        {
            Debug.Log("Hi");
            sc.FlagSave();

            Invoke("NextLevel", 1f);
        }
    }

    private void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
