using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    [SerializeField]
    float speed = 1.0f;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("4")){
            transform.Rotate(Time.deltaTime * speed, 0f, 0f, Space.Self);
        }
        if(Input.GetKeyDown("5")){
            transform.Rotate(-Time.deltaTime * speed, 0f, 0f, Space.Self);
        }
    }
}
