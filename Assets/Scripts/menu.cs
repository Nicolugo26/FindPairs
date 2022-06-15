using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Clase creada para configurar los botones que me llevaran por los diferentes escenarios.

    public void CargarEscena(string escenario)
    {
        SceneManager.LoadScene(escenario);
    }
}
