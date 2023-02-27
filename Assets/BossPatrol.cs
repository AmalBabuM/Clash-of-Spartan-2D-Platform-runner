using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BossPatrol : MonoBehaviour
{
    public float speed;
    public float attackRange = 1;
    public Transform player;
    public Transform[] patrolPoints;

    int currentPoint;
    bool isAttacking;

    enum ActionState { walk, attack };
    int state;
    Animator anim;
    bool flipx;
    Vector3 scale;

    private void Start()
    {
        currentPoint = 0;
        isAttacking = false;
        transform.position = patrolPoints[currentPoint].position;
        anim = GetComponent<Animator>();
        scale= transform.localScale;
        /*icon.flipX= false;*/

    }

    private void Update()
    {
        if (!isAttacking)
        {
            transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currentPoint].position, speed * Time.deltaTime);

            if (Vector2.Distance(transform.position, patrolPoints[currentPoint].position) < 1f)
            {
                currentPoint = (currentPoint + 1) % patrolPoints.Length;
                if (currentPoint == 0)
                {
                    scale.x = Mathf.Abs(scale.x);
                }
                else
                {
                    scale.x = -Mathf.Abs(scale.x);
                }

            }
            transform.localScale = scale;
        }
        if (Vector2.Distance(transform.position, player.position) < attackRange)
        {

            isAttacking = true;
            state = (int)ActionState.attack;

        }
        else
        {
            isAttacking = false;
            state = (int)ActionState.walk;
        }

        anim.SetInteger("state", state);


    }
}
