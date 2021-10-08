using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    private Vector3 Initpost;
    [SerializeField] Vector3 DestPos;
    private Vector3 FinalPos;

    // Start is called before the first frame update
    void Start()
    {
        print(Initpost);
    }

    // Update is called once per frame
    void Update()
    {
        Initpost = transform.position;
        FinalPos = Initpost + DestPos;
    }
}
