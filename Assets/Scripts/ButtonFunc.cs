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
    }

    public void LevelPage()
    {
        SceneManager.LoadScene("GreenLevel");
    }

    public void Next()
    {
        PlayerPrefs.SetInt("levelReached", levelToUnlock);
        SceneManager.LoadScene(nextLevel);
    }
    
}
