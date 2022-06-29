using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddButtonsTres : MonoBehaviour
{
    [SerializeField]
    private Transform Tablero;

    [SerializeField]
    private GameObject btn;

    void Awake()
    {
        for(int i=0; i < 20; i++)
        {
            GameObject button = Instantiate(btn);
            button.name = "" + i;
            button.transform.SetParent(Tablero, false);
        }

    }
}
