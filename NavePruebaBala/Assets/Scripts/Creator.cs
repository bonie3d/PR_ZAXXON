using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour
{

    [SerializeField] GameObject ColumnasPrefab;
    [SerializeField] Transform initpos;
    float separacion;
    float intervalo;
    //[SerializeField] GameObject initObject;
    PosiIni PosiIni;
    [SerializeField] float distanciaObstaculos;



    // Start is called before the first frame update
    void Start()
    {

        intervalo = 0.15f;

        StartCoroutine("CrearObstaculos");

    }

    // Update is called once per frame
    void Update()
    {



    }
    public void Para()
    {

        StopCoroutine("CrearObstaculos");
    }
    IEnumerator CrearObstaculos()
    {

        Vector3 newPos = initpos.position;
        while (true)
        {


            separacion = Random.Range(-20f, 20f);
            Vector3 despl = new Vector3(separacion, 0f, initpos.position.z);
            //intervalo = initGameScript.spaceshipSpeed / distanciaObstaculos;
            Instantiate(ColumnasPrefab, despl, Quaternion.identity);

            yield return new WaitForSeconds(intervalo);


        }

    }








}
