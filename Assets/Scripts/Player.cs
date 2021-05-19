using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform player; 
    public Rigidbody rb;
    public float moveForward = 500f;
    public float moveSideWays = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0, moveForward * Time.deltaTime);
        
        float movX = SimpleInput.GetAxis("Horizontal");

        rb.AddForce(movX * moveSideWays * Time.deltaTime , 0 , 0 , ForceMode.VelocityChange);

    }

    public void Jump()
    {
        if(transform.position.y == 1f)
        {
            rb.AddForce(new Vector3(0, 8f, 0), ForceMode.Impulse);
        }
    }
 
    public void UnFreezeRotation()                     //Unfreeze the player rotation
    {
        rb.constraints = RigidbodyConstraints.None;
    }
}
