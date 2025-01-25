using Unity.VisualScripting;
using UnityEngine;


public class DetectCollision : MonoBehaviour

{
    private Vector3 scaleChange;
    public GameObject Player;
    public float playerScale;

    private void Start()
    {  
        
        Player = GameObject.Find("Player"); 
        scaleChange = new Vector3 (1.5f, 1.5f, 1.5f);
        playerScale = transform.localScale.x;
        playerScale = transform.localScale.y;

    }

    void Update()

    {
       
      
        

    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("detect");
        GameObject.Find("Player");

        {
            Debug.Log("found"); 
        }

        Player.transform.localScale = playerScale * scaleChange;

        {
            Debug.Log(scaleChange);
            Debug.Log(playerScale);
        }

        Destroy(gameObject);
    }

        
    

}


