﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ding : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource audioSource; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ding");
        audioSource.Play();
    }
}
