using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("LevelSelectDay");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exited");
    }
}
