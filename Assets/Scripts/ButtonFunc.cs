using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonFunc : MonoBehaviour
{   
    public void RestartButton()
    {
        FindObjectOfType<GameManager>().Restart();
    }
}
