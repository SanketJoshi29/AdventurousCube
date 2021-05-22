using UnityEngine;
using UnityEngine.SceneManagement;
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
