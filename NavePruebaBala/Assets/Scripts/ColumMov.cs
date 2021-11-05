using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumMov : MonoBehaviour
{
    float speed;
    [SerializeField] GameObject cuboprefab;
    [SerializeField] Transform initPos;


    float desplX = 1f;



    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;

        Vector3 destPos = initPos.position;
        Vector3 despl = new Vector3(desplX, 0, 0);

        for (int n = 0; n < 10; n++)

        {

            Instantiate(cuboprefab, destPos, Quaternion.identity);
            destPos = destPos + despl;

        }

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }


}