using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool GameHasEnded = false;

    public float restartDelay = 1f;

    public void EndGame()
    {
        if(GameHasEnded == false)
        {
            GameHasEnded = true;
            Invoke("Restart", restartDelay); 
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
