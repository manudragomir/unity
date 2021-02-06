using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableOnKeyPress : MonoBehaviour
{
    public KeyCode key;

    void Update()
    {
        if (Input.GetKeyDown(key)) {
            foreach(Transform child in transform)
                child.gameObject.SetActive(!child.gameObject.activeSelf);
        }
    }
}
