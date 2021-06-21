using UnityEngine;

public class PlayBGSound : MonoBehaviour
{
    void Start()
    {
        BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Play();
    }
}

