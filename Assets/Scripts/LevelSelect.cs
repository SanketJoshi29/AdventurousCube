using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void LevelOne()
    {
        SceneManager.LoadScene("Cube");
    }
    public void SideLevel1()
    {
        SceneManager.LoadScene("LevelSelectNight");
    }

    public void SideLevel0()
    {
        SceneManager.LoadScene("LevelSelectDay");
    }
}
