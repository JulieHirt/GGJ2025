using UnityEngine;

public class Spike : MonoBehaviour
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
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            //Call the lose function from gameManager which loads the lose scene
            gameManager.Lose();
        }
    }
}
