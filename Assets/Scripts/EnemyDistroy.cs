using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDistroy : MonoBehaviour
{
    AudioManager audioManager;
    GameObject rb;
    private void Start()
    {
        audioManager=FindObjectOfType<AudioManager>();
        rb = transform.parent.gameObject; 
    }

    public void OnDestroy()
    {
        audioManager.wizardHit();
        Destroy(rb.gameObject);
    }
}
