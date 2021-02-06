using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoOutsideButton : MonoBehaviour
{
    private float minDistance = 3.0f;
    GameObject player;
    private Canvas CanvasObject;
    // Use this for initialization
    void Start ()
    {
        player=GameObject.Find("Player");
        CanvasObject=GameObject.Find("Canvas").GetComponent<Canvas>();
        CanvasObject.enabled=false;
    }
    void Update () 
    {
        float distance=Vector3.Distance(player.transform.position,this.transform.position);
       // Debug.Log(distance);
        if(distance>minDistance){
            CanvasObject.enabled=false;
        }
        else{
            CanvasObject.enabled=true;
        }
    }
    public void btn_next_scene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
