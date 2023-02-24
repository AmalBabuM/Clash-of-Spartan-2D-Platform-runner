using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Player player;
    private void Start()
    {
        player = FindObjectOfType<Player>();
    }
    public static GameManager Instance { get; private set; }
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown("f"))
        {   
           StartCoroutine( ContinueGame());
        }
    }

    public IEnumerator ContinueGame()
    {
        Debug.Log("JJJ");
        
        PlayerData data = SaveSystem.LoadPlayer();

        SceneManager.LoadScene(data.scene);

       
        yield return new WaitForSeconds(5);
       /* player.LoadPlayer();
        player.LoadScene();
*/
        Debug.Log("fit");
        player = FindObjectOfType<Player>();
        /*yield return null;*/
        player.LoadPlayer();


    }
}
