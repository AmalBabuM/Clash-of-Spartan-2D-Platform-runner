using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDistroy : MonoBehaviour
{
    GameObject rb;
    private void Start()
    {
        rb = transform.parent.gameObject; 
    }

    public void OnDestroy()
    {
       
        Destroy(rb.gameObject);
    }
}
