using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeIncomingDogMood : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim;

    bool wait = true;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            anim.SetFloat("dogState", 5.0f);
        }
         if (Input.GetKeyDown("d"))
        {
            anim.SetFloat("dogState", 1.0f);
        }
         if (Input.GetKeyDown("i"))
        {
            anim.SetFloat("dogState", 4.0f);
        }
         if (Input.GetKeyDown("b"))
        {
            anim.SetFloat("dogState", 3.0f);
        }
         if (Input.GetKeyDown("u"))
        {
            anim.SetFloat("dogState", 2.0f);
        }
    }
}
