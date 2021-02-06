using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogBehaviourScene3 : MonoBehaviour
{
    private float minDistance=5;
    private Animator anim;

    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        anim= GetComponent<Animator>();
        player=GameObject.Find("Player");
        anim.SetBool("isSleeping",true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate(){
        float distance=Vector3.Distance(player.transform.position,this.transform.position);
        if(distance<minDistance){
            anim.SetBool("isSleeping",true);
        }
        else{
            anim.SetBool("isSleeping",false);
        }
    }
}
