using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class TiempoDos : MonoBehaviour
{
    public float timer = 0;

    //public Text textoTimer;

    public TextMeshProUGUI textoTiempo;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        //textoTimer.text = "" + timer.ToString("f2");

        //timer -= timer.deltaTime;

        textoTiempo.text = "" + timer.ToString("f2"); //minutos.ToString("00") + ":" + segundos.ToString("00");

        if (timer < 0)
        {
            perder();
            //Time.timeScale = 0f;
        }
    }

    public void perder()
    {
        SceneManager.LoadScene("Perdiste");
    }
}
