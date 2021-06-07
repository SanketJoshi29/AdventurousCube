using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonFunc : MonoBehaviour
{   
    public string nextLevel = "GD2";
    public int levelToUnlock = 2;

    public void RestartButton()
    {
        FindObjectOfType<GameManager>().Restart();
        Time.timeScale = 1f;
    }

    public void LevelPageGreen()
    {
        SceneManager.LoadScene("GreenLevel");
        Time.timeScale = 1f;
    }
    public void LevelPageDesert()
    {
        SceneManager.LoadScene("DesertLevel");
        Time.timeScale = 1f;
    }
    public void LevelPageSnow()
    {
        SceneManager.LoadScene("SnowLevel");
        Time.timeScale = 1f;
    }

    public void NextG()
    {
        PlayerPrefs.SetInt("levelReached", levelToUnlock);
        SceneManager.LoadScene(nextLevel);
    }

    public void NextD()
    {
        PlayerPrefs.SetInt("levelReachedD", levelToUnlock);
        SceneManager.LoadScene(nextLevel);
    }

    public void NextS()
    {
        PlayerPrefs.SetInt("levelReachedS", levelToUnlock);
        SceneManager.LoadScene(nextLevel);
    }
    
}
