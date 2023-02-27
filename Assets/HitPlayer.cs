using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPlayer : MonoBehaviour
{
    AudioManager audioManager;
    HealthBar hb;
    void Start()
    {
        audioManager=FindAnyObjectByType<AudioManager>();
        hb= FindObjectOfType<HealthBar>();
        /*hb=GetComponent<HealthBar>();*/
    }

    public void DamagePlayer()
    {
        audioManager.wizardHit();
        hb.Damage();
    }
}
