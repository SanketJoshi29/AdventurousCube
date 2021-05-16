using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonFunc : MonoBehaviour
{   
    public void RestartButton()
    {
        FindObjectOfType<GameManager>().Restart();
    }

    public void LevelPage()
    {
        SceneManager.LoadScene("GreenLevel");
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
