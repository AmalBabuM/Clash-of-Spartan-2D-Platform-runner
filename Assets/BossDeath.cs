using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossDeath : MonoBehaviour
{
    public Animator anim;
    int health=3;

    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        /*slider= GetComponentInParent<Slider>();*/
        slider.value = health;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Player" )
        {
            

            if(Input.GetKeyDown(KeyCode.Space))
            {
                /*Debug.Log("OMM");*/
                health--;

                slider.value = health;

                if (health == 0)
                {
                    anim.SetTrigger("die");
                }
            }
           
        }
       
    }
}
