using UnityEngine;

public class BounceBubble : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        /*
        if(col.gameObject.tag == "Player")
        {
            Rigidbody2D playerRb = col.gameObject.GetComponent<Rigidbody2D>();
            Vector2 playerVector = playerRb.linearVelocity;

            Vector2 direction = col.gameObject.transform.position - transform.position;
            direction *= playerVector.magnitude;

            playerRb.linearVelocity = direction;
            Debug.Log("bubble changed player velocity");
        }
        */
    }


}
