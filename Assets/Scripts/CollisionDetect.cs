using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    public Player movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            FindObjectOfType<Player>().UnFreezeRotation();
        }
    }

}
