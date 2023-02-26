using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeGame : MonoBehaviour
{
    GameManager gameManager;
    // Start is called before the first frame update

    private void Start()
    {
        gameManager= FindObjectOfType<GameManager>();
    }

    public void LoadLevel()
    {
        gameManager.ResumeGame();
    }

    
}
