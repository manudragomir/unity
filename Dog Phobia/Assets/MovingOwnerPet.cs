using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingOwnerPet : MonoBehaviour
{
    bool moving = false;
    bool barking = false;

    Vector3 direction;

    [SerializeField]
    float speed;

    Animator ownerAnimator;
    Animator petAnimator;

    // Start is called before the first frame update
    void Start()
    {
        direction = transform.forward;
        ownerAnimator = gameObject.transform.Find("Male").gameObject.GetComponent<Animator>();
        petAnimator = gameObject.transform.Find("Dog").gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            moving = !moving;
        }

        if(Input.GetKeyDown("b")){
            barking = !barking;
            if(barking){
                gameObject.transform.Find("Dog").gameObject.GetComponent<AudioSource>().Play();
                petAnimator.SetInteger("status", 3);
            }
            else{
                gameObject.transform.Find("Dog").gameObject.GetComponent<AudioSource>().Stop();
                petAnimator.SetInteger("status", 0);
            }
        }

        if(moving){
            //pornesc moving-ul pe om si caine
            ownerAnimator.SetBool("walk", true);
            petAnimator.SetInteger("status", 1);
            transform.position = transform.position + direction * speed * Time.deltaTime;
        }else{
            //opresc moving-ul pe om si caine
            ownerAnimator.SetBool("walk", false);
            if(petAnimator.GetInteger("status") == 1) petAnimator.SetInteger("status", 0);
        }
        
    }
}
