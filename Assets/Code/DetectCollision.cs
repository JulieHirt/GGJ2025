using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


public class DetectCollision : MonoBehaviour

{
    private Vector3 scaleChange;
    public GameObject Player;
    public float playerScale;
    public bool isTrigger = true;

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

    private void OnTriggerEnter2D (Collider2D other)
    {
        
        GameObject.Find("Player");

       
        Player.transform.localScale = playerScale * scaleChange;

        Destroy(gameObject);
    }

        
    

}


