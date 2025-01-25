using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("update");
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("collided");
    }
}
