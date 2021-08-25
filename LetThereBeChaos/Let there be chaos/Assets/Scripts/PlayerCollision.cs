using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.tag == "Obstacle")
        {

            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
