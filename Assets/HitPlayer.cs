using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPlayer : MonoBehaviour
{
    
    HealthBar hb;
    void Start()
    {
        hb= FindObjectOfType<HealthBar>();
        /*hb=GetComponent<HealthBar>();*/
    }

    public void DamagePlayer()
    {
        hb.Damage();
    }
}
