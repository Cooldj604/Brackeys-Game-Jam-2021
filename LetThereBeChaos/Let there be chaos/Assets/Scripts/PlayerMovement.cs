using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Camera cam;

    public Animator[] Objects;
    public Animator CamTilt;
    public Animator AnimeLines;
    public Animator ChaosBack;

    Vector2 movement;
    Vector2 mousePos;

    PlayerKeycodes characterInput;

    // Start is called before the first frame update
    void Start()
    {
        characterInput = GetComponent<PlayerKeycodes>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement = movement.normalized;

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetKey(characterInput.chaosMode))
        {
            chaos();    

        }else
        {
            foreach(Animator i in Objects)
            {
                i.speed = 0.8f;
            }
       
            CamTilt.SetBool("IsChaos", false);
            AnimeLines.SetBool("IsChaos", false);
            ChaosBack.SetBool("IsChaos", false);
        }

        if (Input.GetKeyDown(characterInput.chaosMode))
        {
            FindObjectOfType<AudioManager>().Play("Chaos");
        }

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }

    void chaos()
    {
        foreach (Animator i in Objects)
        {
            i.speed = 1.75f;
        }

        CamTilt.SetBool("IsChaos", true);
        AnimeLines.SetBool("IsChaos", true);
        ChaosBack.SetBool("IsChaos", true);


    }

}
