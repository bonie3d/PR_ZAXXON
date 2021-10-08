using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveMov : MonoBehaviour
{
    [SerializeField] float desplazspeed;
    [SerializeField] float rotationSpeed = 10f;
    private float LimtX = 14F;

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



        float desplX = Input.GetAxis("Horizontal");
        float desplY = Input.GetAxis("Vertical");
        print(desplX + " - " + desplY);
        //transform.Translate(Vector3.right * Time.deltaTime * desplazspeed * desplX);

        
        //transform.Translate(Vector3.up * Time.deltaTime * desplazspeed * desplY);
        //float desplR = Input.GetAxis("Rotacion");


       //transform.Rotate(0f, 0f, desplR * Time.deltaTime * desplazspeed * -rotationSpeed);



    

            

        }


        

    }

