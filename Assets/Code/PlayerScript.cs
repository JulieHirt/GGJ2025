using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed;
    public float downSpeed;
    public float sideMaxSpeed;
    public float bounceMinimzeAmount;

    //public PhysicsMaterial2D highBounceMat;
    //public PhysicsMaterial2D lowBounceMat;

    //Vector2 lastSpeed;

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

    void OnCollisionEnter2D()
    {
        /*
        if (slammingDown)
        {
            Vector2 newVelocity = new Vector2(lastSpeed.x, -lastSpeed.y);
            rb.linearVelocity = newVelocity;
        }
        slammingDown = false;
        */
    }

    private void OnTriggerEnter2D(Collider2D collision) // this is so that when the ball is about to hit something at high speed, we save its speed BEFORE it hits.  If we wait till it actually hits, then velocity values get messed up for calculation
    { 

        Vector2 newVelocity = new Vector2(rb.linearVelocity.x, -(rb.linearVelocity.y / bounceMinimzeAmount));
        rb.linearVelocity = newVelocity;

        GetComponent<Collider2D>().isTrigger = false;
    }

    IEnumerator SetBounceToHigh()
    {
        yield return new WaitForSeconds(0.05f);
        //rb.sharedMaterial = highBounceMat;
    }

    private void FixedUpdate()
    {

            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                if(rb.linearVelocityX < sideMaxSpeed)
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
            GetComponent<Collider2D>().isTrigger = true;
        }

    }


}
