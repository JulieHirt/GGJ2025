using UnityEngine;

public class ReduceSize : MonoBehaviour
 

{
    private Vector3 scaleChange;
    public GameObject Player;
    public float playerScale;

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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject.Find("Player");
        Player.transform.localScale = scaleChange * playerScale;
        Destroy(gameObject);
    }
}
