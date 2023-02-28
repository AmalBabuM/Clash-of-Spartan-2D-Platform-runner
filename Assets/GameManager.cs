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
    /*public static GameManager Instance { get; private set; }*/
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

    /*private void Update()
    {
        if(Input.GetKeyDown("f"))
        {   
           StartCoroutine( ContinueGame());
        }
    }*/

    public void ResumeGame()
    {
        StartCoroutine( ContinueGame());
    }

    public IEnumerator ContinueGame()
    {
        Debug.Log("123");

        PlayerData data = SaveSystem.LoadPlayer();

        SceneManager.LoadScene(data.scene);
        /*player.LoadScene();*/

        Debug.Log("456");
        yield return new WaitUntil(() => SceneManager.GetActiveScene().buildIndex == data.scene);

      /*yield return new WaitUntil(() => SceneManager.GetActiveScene().buildIndex == 1);*/
        /*yield return new WaitForSeconds(0.5f);*/
       /* player.LoadPlayer();
        player.LoadScene();
*/
        Debug.Log("789");
        player = FindObjectOfType<Player>();
        /*yield return null;*/
        player.LoadPlayer();


    }
}
