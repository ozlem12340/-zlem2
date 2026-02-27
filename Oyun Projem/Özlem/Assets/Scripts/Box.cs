using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        print("Hello World");
    }

    // Update is called once per frame

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + Vector3.forward * 1f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + Vector3.back * 1f * Time.deltaTime;
        }
    }
}
