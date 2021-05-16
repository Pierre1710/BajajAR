using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatColor : MonoBehaviour
{
public Material[] BodyColorMat;
private Material CurrMat;
private  Renderer renderers;

    // Use this for initialization
    void Start()
    {
        renderers = this.GetComponent<Renderer>();
    }

   //render color azul
    public void BlueColor()
    {
        renderers.material = BodyColorMat[0];
        CurrMat = renderers.material;
    }

    //render color rojo
    public void RedColor()
    {
        renderers.material = BodyColorMat[1];
        CurrMat = renderers.material;
    }

    //render color verde
    public void GreenColor()
    {
        renderers.material = BodyColorMat[2];
        CurrMat = renderers.material;
    }


    //render color Amarillo
    public void YellowColor()
    {
        renderers.material = BodyColorMat[3];
        CurrMat = renderers.material;
    }

    //render color Negro
    public void BLackColor()
    {
        renderers.material = BodyColorMat[4];
        CurrMat = renderers.material;
    }

    //render color Blanco
    public void WhiteColor()
    {
        renderers.material = BodyColorMat[5];
        CurrMat = renderers.material;
    }
}
