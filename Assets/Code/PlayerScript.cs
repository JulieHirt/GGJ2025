using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed;
    public float downSpeed;
    public float sideMaxSpeed;
    public float maxBounceSpeed;

    Rigidbody2D rb;
    bool pressedSpace = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pressedSpace = true;
        }
    }

    void OnTriggerEnter2D()
    {

    }

    private void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            if (rb.linearVelocityX < sideMaxSpeed)
            {
                rb.AddForce(Vector2.right * moveSpeed);
            }
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.D))
        {
            if (rb.linearVelocityX > sideMaxSpeed || Mathf.Abs(rb.linearVelocityX) < sideMaxSpeed)
            {
                rb.AddForce(Vector2.left * moveSpeed);
            }
        }

        
        if (pressedSpace == true)
        {
            rb.linearVelocityY = -downSpeed;
            pressedSpace = false;
            //GetComponent<Collider2D>().isTrigger = true;
        }

        // BRUTE FORCING THE BUBBLE TO SLOW DOWN IF IT'S TOO FAST.  AGHHHHHH
        if(rb.linearVelocity.y > maxBounceSpeed)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, maxBounceSpeed);
            //rb.linearVelocity.y = maxBounceSpeed;
        }

    }
}
