using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveMov : MonoBehaviour
{
    [SerializeField] float desplazspeed;
    [SerializeField] float rotationSpeed = 10f;
    [SerializeField] float LimiteX = 20f;
    


    // Start is called before the first frame update
    void Start()
    {
        desplazspeed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        Movimient();
    }

    void Movimient()
    {
        

            if (transform.position.x < -LimiteX)
            {
                transform.position = new Vector3(-LimiteX, transform.position.y, transform.position.z);

                if (transform.position.x > LimiteX)

                    
                    {
                        transform.position = new Vector3(LimiteX, transform.position.y, transform.position.z);
                    }

                float desplX = Input.GetAxis("Horizontal");
                float desplY = Input.GetAxis("Vertical");
                print(desplX + " - " + desplY);
                transform.Translate(Vector3.right * Time.deltaTime * desplazspeed * desplX);
                transform.Translate(Vector3.up * Time.deltaTime * desplazspeed * desplY);
                float desplR = Input.GetAxis("Rotacion");
                transform.Rotate(0f, 0f, desplR * Time.deltaTime * desplazspeed * -rotationSpeed);

                {
                    // if (posX < limiteH && desplX < 0f)
                }
                transform.Translate(Vector3.right * Time.deltaTime * desplazspeed * desplX);
            }

    }

}