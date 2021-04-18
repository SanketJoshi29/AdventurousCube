using UnityEngine;

public class EndPointTrigger : MonoBehaviour
{
    public Player movement;

    public GameManager gameManager;
    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
        movement.enabled = false;
    }
}
