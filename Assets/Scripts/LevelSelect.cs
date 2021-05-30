using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{
    public Button[] levelButtons;
 
    void Start()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached", 0);

        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 2 > levelReached)
            {
                levelButtons[i].interactable = false;
            }
        }
    }

    public void Select(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
