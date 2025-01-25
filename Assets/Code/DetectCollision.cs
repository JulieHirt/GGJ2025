using UnityEngine;


public class DetectCollision : MonoBehaviour
{
    private void Start()
    {

    }
    void Update()
    {


    }
    private void OnCollisionEnter2D (Collision2D coll)
    {
        Debug.Log ("detect");
        Destroy(gameObject);

    }
}