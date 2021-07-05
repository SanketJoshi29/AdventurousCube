using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MuteManager : MonoBehaviour
{
    [SerializeField] Image soundOnIcon;
    [SerializeField] Image soundOffIcon;
    private bool isMuted;
    void Start()
    {
        isMuted = PlayerPrefs.GetInt("isMuted") == 1;
        if (PlayerPrefs.HasKey("isMuted"))
        {
            Load();
        }
        else
        {
            PlayerPrefs.SetInt("isMuted",1);
            Save();
        }
        AudioListener.pause = isMuted;
        UpdateButtonIcon();
    }

    public void MutePressed()
    {
        isMuted = !isMuted;
        AudioListener.pause = isMuted;

        UpdateButtonIcon();
        Save();
    }

    private void UpdateButtonIcon()
    {
        if(isMuted == false)
        {
            soundOnIcon.enabled = true;
            soundOffIcon.enabled = false;
        }
        else
        {
            soundOnIcon.enabled = false;
            soundOffIcon.enabled = true;
        }   
    }
    private void Load()
    {
        isMuted = PlayerPrefs.GetInt("isMuted") == 1;
    }

    private void Save()
    {
        PlayerPrefs.SetInt("isMuted", isMuted ? 1 : 0);
    }
}
