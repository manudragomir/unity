using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //var force = 2000.0f;
        //var cannonShooter = GameObject.Find("/Cannon/RotationPoint/CannonShooter").transform.position;
        //var rotationPoint = GameObject.Find("/Cannon/RotationPoint").transform.position;
        //Ray ray = new Ray(rotationPoint, cannonShooter - rotationPoint);
        //GetComponent<Rigidbody>().AddForce(ray.direction.normalized * force);
    }

    // Update is called once per frame
    void Update()
    {
        var cannonShooter = GameObject.Find("/Cannon/RotationPoint/CannonShooter").transform.position;
        var rotationPoint = GameObject.Find("/Cannon/RotationPoint").transform.position;
       // Debug.DrawLine(rotationPoint, cannonShooter, Color.red, 2000, false);
    }
}
