
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// La clase casilla se ejecuta dentro el objeto plincipal que se llama Carta

public class Casilla : MonoBehaviour
{
    
    public Material colorCasilla;  
    public int NumCasilla = 0;
    public Vector3 posicionOriginal; //Me ayuda a guardar la posicion original donde comienza la casilla

    void OnMouseDown()
    {
        print (NumCasilla.ToString());
    }

    
    // Funcion que me ayuda asignar una imagen a cada casilla creada, las imagenes estan en la carpeta imagenes y dentro del elemento script que esta en la escena "Juego"
    public void PonerColor(Texture2D textura)
    {
        GetComponent<MeshRenderer>().material.mainTexture = textura;
        //colorCasilla = color_;
    }
}
