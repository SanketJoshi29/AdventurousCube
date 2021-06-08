using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelectDesert : MonoBehaviour
{
    public Button[] levelButtons;
 
    void Start()
    {
        int levelReachedD = PlayerPrefs.GetInt("levelReachedD", 1);

        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 1 > levelReachedD)
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
