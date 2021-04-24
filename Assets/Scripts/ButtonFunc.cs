using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonFunc : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("Cube");
    }
}
