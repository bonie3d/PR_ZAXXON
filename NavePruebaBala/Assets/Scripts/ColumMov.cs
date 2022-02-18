using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumMov : MonoBehaviour
{
    float speed;
    [SerializeField] GameObject cuboprefab;
    [SerializeField] Transform initPos;

    float separacion;
    float intervalo;
    //[SerializeField] GameObject initObject;
    PosiIni PosiIni;
    [SerializeField] float distanciaObstaculos;


    float desplX = 4f;



    // Start is called before the first frame update
    void Start()
    {
        speed = 15f;
        /*
        intervalo = 0.15f;

        //StartCoroutine("CrearObstaculos");

        Vector3 destPos = initPos.position;
        Vector3 despl = new Vector3(desplX, 0, 0);

        for (int n = 0; n < 10; n++)

        {

            Instantiate(cuboprefab, destPos, Quaternion.identity);
            destPos = destPos + despl;

        }
*/
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }


}
