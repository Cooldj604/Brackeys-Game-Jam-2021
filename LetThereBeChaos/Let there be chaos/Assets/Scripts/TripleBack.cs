using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TripleBack : MonoBehaviour
{
    public void tripleback()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
}
