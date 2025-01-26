using Unity.VisualScripting;
using UnityEngine;


public class DetectCollision : MonoBehaviour

{
    private Vector3 scaleChange;
    public GameObject Player;
    public bool isTrigger = true;

    public float playerScale;

    private void Start()
    {  
        
        Player = GameObject.Find("Player"); 
        scaleChange = new Vector3 (playerScale, playerScale, playerScale);
        
       
       

    }

    void Update()

    {
       
      
        

    }

    private void OnTriggerEnter2D (Collider2D other)
    {
        
        GameObject.Find("Player");

       
        Player.transform.localScale = scaleChange;

        Destroy(gameObject);
    }

        
    

}


