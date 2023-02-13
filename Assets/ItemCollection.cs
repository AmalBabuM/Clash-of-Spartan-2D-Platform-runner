using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollection : MonoBehaviour
{
    int score = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Eatable"))
        {
            score++;
            Destroy(collision.gameObject);

            Debug.Log(score);
        }

    }

}
