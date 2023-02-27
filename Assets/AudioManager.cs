using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip jumpSound;
    public AudioClip coin;
    public AudioClip playerAttack;
    public AudioClip enemyAttack;
    public AudioClip playerDeath;
    public AudioClip enemyDeath;
    public AudioClip winning;
   
    
    public AudioSource bgMusic;
    public AudioSource source;
    
    // Start is called before the first frame update
    void Start()
    {
        bgMusic.Play();

    }

   
    public void BackgroundMusic()
    {
        if (bgMusic.isPlaying)
        {
            bgMusic.Pause();
        }
        else
        {
            bgMusic.Play();
        }
    }
   

    public void JumpSound()
    {
        source.PlayOneShot(jumpSound);
    }
    public void swordHit()
    {
        source.PlayOneShot(playerAttack);
    }
    public void wizardHit()
    {
        source.PlayOneShot(enemyAttack);
    }

    public void CoinCollect()
    {
        source.PlayOneShot(coin);
    }
    public void DeathSound()
    {
        source.PlayOneShot(playerDeath);
    }

    public void EnemyDeathSound()
    {
        source.PlayOneShot(enemyDeath);
    }
    public void NextLevel()
    {
        source.PlayOneShot(winning);
    }
}
