using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform player; 
    public Rigidbody rb;
    public float moveForward = 500f;
    public float moveSideWays = 500f;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0, moveForward * Time.deltaTime);
        
        if(Input.GetKey("d"))
        {
            rb.AddForce(moveSideWays * Time.deltaTime , 0 , 0 , ForceMode.VelocityChange);
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-moveSideWays * Time.deltaTime , 0 , 0 , ForceMode.VelocityChange);
        }
        
        if(Input.GetKey("space") && transform.position.y <= 2f)
        {
            rb.AddForce(new Vector3(0, 0.75f, 0), ForceMode.Impulse);
        }
    }
    
    public void UnFreezeRotation()                     //Unfreeze the player rotation
    {
        rb.constraints = RigidbodyConstraints.None;
    }
}
