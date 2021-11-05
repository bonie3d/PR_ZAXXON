using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovNave : MonoBehaviour
{
    //Variables para el movimiento
    [SerializeField] float desplSpeed;
    [SerializeField] float rotationSpeed;

    //Variables para restricci�n de movimiento
    float limiteH = 18f; //Solo creo una porque por la izquierda es la misma pero en negativo
    float limiteV = 10f;
    float limiteSuelo = 1f;

    // Start is called before the first frame update
    void Start()
    {
        //Asigno el valor a las variables de movimiento
        desplSpeed = 20f;
        rotationSpeed = 100f; //La de rotaci�n es alta porque la rotaci�n es muy lenta

    }

    // Update is called once per frame
    void Update()
    {
        //IMPORTANTE: el m�todo Update tiene que estar vac�o
        MoverNarve();

    }


    //M�todo que mueve la nave
    void MoverNarve()
    {
        //Obtengo los valores de los ejes
        float desplX = Input.GetAxis("Horizontal");
        float desplY = Input.GetAxis("Vertical");
        //float desplR = Input.GetAxis("Rotation"); //Este lo he creado en Input Manager

        //Obtengo la posici�n de la nave
        float posX = transform.position.x;
        float posY = transform.position.y;

        //Muevo la nave solo si se dan las condiciones ideales
        if ((posX < limiteH || desplX < 0f) && (posX > -limiteH || desplX > 0f))
        {
            transform.Translate(Vector3.right * Time.deltaTime * desplSpeed * desplX, Space.World);
        }

        if ((posY < limiteV || desplY < 0f) && (posY > limiteSuelo || desplY > 0f))
        {
            transform.Translate(Vector3.up * Time.deltaTime * desplSpeed * desplY, Space.World);
        }

        //Rotaci�n con joystick derecho
        //transform.Rotate(0f, 0f, desplR * Time.deltaTime * -rotationSpeed);

        /*
        //Esta forma alternativa de retringir movimiento no siempre funciona
        if(posX > limiteH && desplX > 0f)
        {
            transform.position = new Vector3(posX, transform.position.y, transform.position.z);
        }
        else if(posX < -limiteH && desplX < 0f)
        {
            transform.position = new Vector3(posX, transform.position.y, transform.position.z);
        }
        */
    }

}
