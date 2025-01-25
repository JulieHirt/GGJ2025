using UnityEngine;

public class ReduceSize : MonoBehaviour
 

{
    private Vector3 scaleChange;
    public GameObject Player;
    public float playerScale;
    public bool isTrigger = true;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player = GameObject.Find("Player");
        scaleChange = new Vector3(.5f,.5f,.5f);
        playerScale = transform.localScale.x;
        playerScale = transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject.Find("Player");
        Player.transform.localScale = scaleChange * playerScale;
        Destroy(gameObject);
    }
}
