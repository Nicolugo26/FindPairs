using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casilla : MonoBehaviour
{
    
    public Material colorCasilla;
    public int NumCasilla = 0;
    public Vector3 posicionOriginal;

    void OnMouseDown()
    {
        print (NumCasilla.ToString());
    }

    
    public void PonerColor(Texture2D textura)
    {
        GetComponent<MeshRenderer>().material.mainTexture = textura;
        //colorCasilla = color_;
    }
}
