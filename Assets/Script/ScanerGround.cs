using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScanerGround : MonoBehaviour
{
    public Texture2D[] frames;
    public int Vel = 10;
    void Update()
    {
       int index = (int)(Time.time * Vel) % frames.Length;
        GetComponent<RawImage>().texture = frames[index];
    }
}
