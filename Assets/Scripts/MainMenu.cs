using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("LevelSelection");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exited");
    }
}
