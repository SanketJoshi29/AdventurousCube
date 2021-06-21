using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonFunc : MonoBehaviour
{   
    public void RestartButton()
    {
        FindObjectOfType<GameManager>().Restart();
        Time.timeScale = 1f;
    }

    public void LevelPageGreen()
    {
        SceneManager.LoadScene("GreenLevel");
        Time.timeScale = 1f;
        BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Play();
    }
    public void LevelPageDesert()
    {
        SceneManager.LoadScene("DesertLevel");
        Time.timeScale = 1f;
        BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Play();
    }
    public void LevelPageSnow()
    {
        SceneManager.LoadScene("SnowLevel");
        Time.timeScale = 1f;
        BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Play();
    }

    public void Next(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void NextM(string levelName)
    {
        SceneManager.LoadScene(levelName);
        BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Play();
    }
    
}
