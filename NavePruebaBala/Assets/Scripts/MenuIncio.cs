using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuIncio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EscenaJuego()
    {
        SceneManager.LoadScene("pruebanave");
    }

    public void CargarMenu(string menuinicio)
       
    {
        SceneManager.LoadScene("Menu");

       
    }

    public void Salir ()
    {
        SceneManager.LoadScene("Exit");

        Application.Quit();
    }
}
