using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Columnamove : MonoBehaviour
{
    float speed;
    





    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;



    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }


}