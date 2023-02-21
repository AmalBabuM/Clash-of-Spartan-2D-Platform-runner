using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    Slider slider;
    int health;
    public Animator anim;
    void Start()
    {
      slider=GetComponent<Slider>();
        health = 20;
        SetValue(health);
    }

    public void Damage()
    {
        Debug.Log("HI there");
        health -= 5;
        SetValue(health);

        
    }

    public void SetValue(int value)
    {
        slider.value = value;
        if (value == 0)
        {
            anim.SetTrigger("dead");
        }
    }
}
