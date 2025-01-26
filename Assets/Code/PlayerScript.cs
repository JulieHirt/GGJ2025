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
    public float highBounceSpeed;

    Rigidbody2D rb;
    bool pressedSpace = false;
    Animator theAnimator;
    string state = "normal"; // states are normal, bouncing, popped.
                             // normal -> bouncing -> normal.  or normal -> popped  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        theAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pressedSpace = true;
        }


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
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            if (rb.linearVelocityX > sideMaxSpeed || Mathf.Abs(rb.linearVelocityX) < sideMaxSpeed)
            {
                rb.AddForce(Vector2.left * moveSpeed);
            }
        }


        if (pressedSpace == true)
        {
            rb.linearVelocityY = -downSpeed;
            state = "bouncing";

            pressedSpace = false;
            //GetComponent<Collider2D>().isTrigger = true;
        }

        // BRUTE FORCING THE BUBBLE TO SLOW DOWN IF IT'S TOO FAST.  AGHHHHHH
        if (rb.linearVelocity.y > maxBounceSpeed)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, maxBounceSpeed);
            //rb.linearVelocity.y = maxBounceSpeed;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "BounceBubble" || col.gameObject.tag == "BounceBubbleHigh")
        {
            //Rigidbody2D playerRb = col.gameObject.GetComponent<Rigidbody2D>();
            Vector2 playerVector = rb.linearVelocity;

            Vector2 direction = transform.position - col.gameObject.transform.position;
            direction *= playerVector.magnitude;

            if (col.gameObject.tag == "BounceBubbleHigh")
            {
                direction *= highBounceSpeed;
            }
            rb.linearVelocity = direction;
            Destroy(col.gameObject);

            ActivateBounceAnimation();
        }

    }

    public void ActivateBounceAnimation()
    {
        theAnimator.SetBool("isCollided", true);
        float animationTime = theAnimator.GetCurrentAnimatorStateInfo(0).length;
        StartCoroutine(DisableBouncingBool(animationTime));
    }

    public void ActivatePopAnimation()
    {
        theAnimator.SetBool("isPopped", true);
        float animationTime = theAnimator.GetCurrentAnimatorStateInfo(0).length;
        StartCoroutine(DisablePoppedBool(animationTime));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Platform")
        {
            ActivateBounceAnimation();
        }
        else
        {
            theAnimator.SetBool("isPopped", true);
        }
  
    }

    IEnumerator DisableBouncingBool(float time)
    {
        yield return new WaitForSeconds(time);
        theAnimator.SetBool("isCollided", false);
    }

}
