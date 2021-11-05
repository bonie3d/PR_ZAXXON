using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{

    public GameObject Bala;
    public Transform SpawnPiont;

    public float ShotForce = 1500;
    public float ShotRate = 0.5f;

    private float ShotRateTime = 0;



    // Update is called once per frame
    void Update()
    {

        if(Input.GetButtonDown("Fire1"))
            {

            if(Time.time>ShotRateTime)
            {

                GameObject nuevaBala;

                nuevaBala = Instantiate(Bala,SpawnPiont.position,SpawnPiont.rotation);

                nuevaBala.GetComponent<Rigidbody>().AddForce(SpawnPiont.forward*ShotForce);

                ShotRateTime = Time.time + ShotRate;

                Destroy(nuevaBala, 2);




            }

        }
    }
}
