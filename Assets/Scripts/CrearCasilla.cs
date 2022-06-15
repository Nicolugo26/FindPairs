using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCasilla : MonoBehaviour
{
    public GameObject CasillaPrefab;
    
    public int Ancho;
    //public int Alto;
    public Transform CasillasParent;

    private List<GameObject> casillas = new List<GameObject>();

    public Material[] materiales;
    public Texture2D[] texturas;


    void Start()
    {
        crear();
    }

    public void crear()
    {
        int cont = 0;
        for(int i = 0; i < Ancho; i++)
        {
            for(int x = 0; x < Ancho; x++)
            {
                GameObject casillaTemp = Instantiate(CasillaPrefab, new Vector3(x, 0, i), 
                    Quaternion.Euler(new Vector3(0,180,0)));
                casillas.Add(casillaTemp);

                    casillaTemp.GetComponent<Casilla>().posicionOriginal = new Vector3(x, 0, i);
                    casillaTemp.GetComponent<Casilla>().NumCasilla = cont;

                    casillaTemp.transform.parent = CasillasParent;
                cont++;
            }

        }
        AsignarTexturas();
        Barajar();
    }

    void AsignarTexturas()
    {
        for(int i = 0; i < casillas.Count; i++)
        {
           casillas[i].GetComponent<Casilla>().PonerColor(texturas[(i)/2]);
        }
    }

   void Barajar()
    {
        int aleatorio;
        for(int i=0; i < casillas.Count; i++)
        {
            aleatorio = Random.Range(i, casillas.Count);

            casillas[i].transform.position = casillas[aleatorio].transform.position;
            casillas[aleatorio].transform.position = casillas[i].GetComponent<Casilla>().posicionOriginal;

            casillas[i].GetComponent<Casilla>().posicionOriginal = casillas[i].transform.position;
            casillas[aleatorio].GetComponent<Casilla>().posicionOriginal = casillas[aleatorio].transform.position;
        }
    }
}