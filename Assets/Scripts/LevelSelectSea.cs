using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelectSea : MonoBehaviour
{
    public Button[] levelButtons;
 
    void Start()
    {
        //PlayerPrefs.DeleteAll();

        int levelReachedSea = PlayerPrefs.GetInt("levelReachedSea", 1);

        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 1 > levelReachedSea)
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
