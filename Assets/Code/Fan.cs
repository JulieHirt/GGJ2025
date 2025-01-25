using Unity.VisualScripting;
using UnityEngine;

public class Fan : MonoBehaviour
{
    //magnitude of the force emitted by the fan. 
    //increases the longer the object is within range of the fan
    private float magnitude = 1f;

    //cap the force magnitude at this value, it cannot get bigger than this
    public float maxMagnitude = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("entered trigger");
        //apply a force
       

        Rigidbody2D rig = collision.GetComponent<Rigidbody2D>();
        rig.AddForce(new Vector3(0,1,0)*magnitude, ForceMode2D.Impulse);

        //Debug.Log(Vector3.forward * magnitude);
        //Debug.Log(rig.gameObject);


    }


    void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("stay in trigger");
        if (magnitude < maxMagnitude)
        {
            magnitude += .5f;
            Debug.Log("increase magnitude to" + magnitude);
        }
        Rigidbody2D rig = collision.GetComponent<Rigidbody2D>();
        rig.AddForce(new Vector3(0, 1, 0) * magnitude, ForceMode2D.Impulse);
    }
}
