using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour
{
    //Pendiente: cambiar el intervalo en base a la velocidad
    float intervalo;

    //Creo un ARRAY (por eso los corchetes) para los obstáculos
    //En Unity, daré al nº de elementos del array y sus prefabs
    [SerializeField] GameObject[] obstaculos;

    //Posición donde se instanciarán los obstáculos
    [SerializeField] Transform instantiatePos;
    //Límites de posición para los obstáculos
    float limiteL = -18f;
    float limiteR = 18f;


    // Start is called before the first frame update
    void Start()
    {
        intervalo = 1f;

        //Inicio la corrutina que crea los obstáculos
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

            //Posición Random en X
            float randomX = Random.Range(limiteL, limiteR);
            //Posición de instanciación, según el valor Random en X
            Vector3 newPos = new Vector3(randomX, instantiatePos.position.y, instantiatePos.position.z);

            //Genero un nº aleatorio para elegir obstaculo
            int numAl = Random.Range(0, obstaculos.Length);
            //Instancio el elemento del Array aleatorio
            Instantiate(obstaculos[numAl], newPos, Quaternion.identity);

            /*
            //Este código es una forma de instanciar diferentes prefabs modo DUMMIE
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
