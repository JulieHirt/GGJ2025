using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour
{
    GameManager gameManager;

    public void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
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
        if (col.gameObject.CompareTag("Player"))
        {
            //Call the win function from gameManager which loads the win scene
            gameManager.Win();
        }
    }
}
