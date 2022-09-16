using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BG_Scroll : MonoBehaviour
{
    [SerializeField] private RawImage background;
    [SerializeField] private float x, y;

    // Update is called once per frame
    void Update()
    {
       background.uvRect = new Rect(background.uvRect.position + new Vector2(x, y) * Time.deltaTime, background.uvRect.size); 
    }
}
