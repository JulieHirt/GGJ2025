using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector2.right * moveSpeed);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector2.left * moveSpeed);
        }
    }

    private void FixedUpdate()
    {
        
    }
}
