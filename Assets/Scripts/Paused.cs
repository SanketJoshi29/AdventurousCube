using UnityEngine;
using UnityEngine.UI;

public class Paused : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject touch;
    public GameObject jumpButton;
    public GameObject pauseButton;
    // Update is called once per frame
    void Update()
    {
       
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        touch.SetActive(false);
        jumpButton.SetActive(false);
        pauseButton.SetActive(false);
        
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        touch.SetActive(true);
        jumpButton.SetActive(true);
        pauseButton.SetActive(true);
    }
}
