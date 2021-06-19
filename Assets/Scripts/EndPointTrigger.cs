using UnityEngine;
using UnityEngine.SceneManagement;
public class EndPointTrigger : MonoBehaviour
{

    public Player movement;
    public GameManager gameManager;
    public AudioSource levelCompleteAudio;
    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
        movement.enabled = false;
        levelCompleteAudio.enabled = true;
    }
}
