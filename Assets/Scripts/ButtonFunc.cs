using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonFunc : MonoBehaviour
{   
    public string nextLevel = "GD2";
    public int levelToUnlock = 2;

    public string nextLevelD = "Desert2";
    public int levelToUnlockD = 2;

    public string nextLevelS = "Snow2";
    public int levelToUnlockS = 2;

    public string nextLevelSea = "Sea2";
    public int levelToUnlockSea = 2;
    
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
    public void LevelPageSea()
    {
        SceneManager.LoadScene("SeaLevel");
        Time.timeScale = 1f;
        BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Play();
    }

    public void Next()
    {
        if(PlayerPrefs.GetInt("levelReached") < levelToUnlock)
        {
            PlayerPrefs.SetInt("levelReached", levelToUnlock);
        }
        SceneManager.LoadScene(nextLevel);
    }
    public void NextD()
    {
        if(PlayerPrefs.GetInt("levelReachedD") < levelToUnlockD)
        {
            PlayerPrefs.SetInt("levelReachedD", levelToUnlockD);
        }
        SceneManager.LoadScene(nextLevelD);
    }
    public void NextS()
    {
        if(PlayerPrefs.GetInt("levelReachedS") < levelToUnlockS)
        {
            PlayerPrefs.SetInt("levelReachedS", levelToUnlockS);
        }
        SceneManager.LoadScene(nextLevelS);
    }
    public void NextSea()
    {
        if(PlayerPrefs.GetInt("levelReachedSea") < levelToUnlockSea)
        {
            PlayerPrefs.SetInt("levelReachedSea", levelToUnlockSea);
        }
        SceneManager.LoadScene(nextLevelSea);
    }

    public void NextM(string levelName)
    {
        SceneManager.LoadScene(levelName);
        BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Play();
    }
}
