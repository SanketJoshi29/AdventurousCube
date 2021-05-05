using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void LevelOne()
    {
        SceneManager.LoadScene("Cube");
    }
    public void SideLevel()
    {
        SceneManager.LoadScene("LevelSelectNight");
    }
}
