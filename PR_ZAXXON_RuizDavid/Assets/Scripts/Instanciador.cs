using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour
{
    //Pendiente: cambiar el intervalo en base a la velocidad
    float intervalo;

    //Creo un ARRAY (por eso los corchetes) para los obst�culos
    //En Unity, dar� al n� de elementos del array y sus prefabs
    [SerializeField] GameObject[] obstaculos;

    //Posici�n donde se instanciar�n los obst�culos
    [SerializeField] Transform instantiatePos;
    //L�mites de posici�n para los obst�culos
    float limiteL = -18f;
    float limiteR = 18f;


    // Start is called before the first frame update
    void Start()
    {
        intervalo = 1f;

        //Inicio la corrutina que crea los obst�culos
        StartCoroutine("CrearColumna");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator CrearColumna()
    {
        while (true)
        {

            //Posici�n Random en X
            float randomX = Random.Range(limiteL, limiteR);
            //Posici�n de instanciaci�n, seg�n el valor Random en X
            Vector3 newPos = new Vector3(randomX, instantiatePos.position.y, instantiatePos.position.z);

            //Genero un n� aleatorio para elegir obstaculo
            int numAl = Random.Range(0, obstaculos.Length);
            //Instancio el elemento del Array aleatorio
            Instantiate(obstaculos[numAl], newPos, Quaternion.identity);

            /*
            //Este c�digo es una forma de instanciar diferentes prefabs modo DUMMIE
            if(numAl == 0)
            {
                //Instantiate(columna, newPos, Quaternion.identity);
            }
            else
            {
                //Instantiate(pared, newPos, Quaternion.identity);
            }
            */

            //Repito el intervalo de la corrutina
            yield return new WaitForSeconds(intervalo);
        }
    }
}
