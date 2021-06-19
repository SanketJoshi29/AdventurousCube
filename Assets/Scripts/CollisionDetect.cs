using UnityEngine;
using UnityEngine.Audio;

public class CollisionDetect : MonoBehaviour
{
    public Player movement;
    public AudioSource crashSound;
    public AudioSource track;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            FindObjectOfType<Player>().UnFreezeRotation();
            crashSound.enabled = true;
            track.enabled = false;
        }
    }

}
