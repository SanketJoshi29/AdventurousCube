using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelectSnow : MonoBehaviour
{
    public Button[] levelButtons;
 
    void Start()
    {
        int levelReachedS = PlayerPrefs.GetInt("levelReachedS", 1);

        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 1 > levelReachedS)
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
