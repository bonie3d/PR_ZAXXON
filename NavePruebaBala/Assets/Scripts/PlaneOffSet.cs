using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaneOffSet : MonoBehaviour
{
    public Text score;

    Renderer rend;

    [SerializeField] Vector2 desplz;

    MovNave MovNave;

    [SerializeField] float scrollSpeed;
    void Start()
    {
        rend = GetComponent<Renderer>();

        GameObject InitEmpty = GameObject.Find("InitEmpty");
        MovNave = InitEmpty.GetComponent<MovNave>();
    }

   
    void Update()
    {

        //scrollSpeed = MovNave / 2;

        float offset = Time.time * scrollSpeed;

        desplz = new Vector2(0, -offset);

        rend.material.SetTextureOffset("_MainTex", desplz);
        rend.material.SetTextureOffset("_BumpMap", desplz);

        score.text = transform.position.z.ToString();


    }
}
