using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelectGreen : MonoBehaviour
{
    public Button[] levelButtons;
 
    void Start()
    {
        //PlayerPrefs.DeleteAll();

        int levelReached = PlayerPrefs.GetInt("levelReached", 1);

        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 1 > levelReached)
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
