using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool gameHasEnded = false;
    public float restartDelayTime = 1f;
    public GameObject completeLevelUI;
    public GameObject touch;
    public GameObject jumpButton;

    public int target = 60;

    public void Update()
    {
        if (target != Application.targetFrameRate)
        {
            Application.targetFrameRate = target;
        }
        
    }
    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart" , restartDelayTime);      //Invoke take two parameters. 1st - function to be called & 2nd - Delaytime
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        touch.SetActive(false);
        jumpButton.SetActive(false);
    }
}
