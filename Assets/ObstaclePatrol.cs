using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePatrol : MonoBehaviour
{
    public float speed;
  
   
    public Transform[] patrolPoints;

    int currentPoint;
   

   
    
   
    private void Start()
    {
        currentPoint = 0;
        
        transform.position = patrolPoints[currentPoint].position;
        

    }

    private void Update()
    {
       
       transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currentPoint].position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, patrolPoints[currentPoint].position) < 1f)
        {
            currentPoint = (currentPoint + 1) % patrolPoints.Length;
        }
    }
}
