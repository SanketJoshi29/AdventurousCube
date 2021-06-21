using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{
    public void Select(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
