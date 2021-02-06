using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lansator : MonoBehaviour
{
    [SerializeField] private GameObject projectile;

    void Shoot()
    {
        var proj = Instantiate(projectile, transform.position, Quaternion.identity, transform);
        var myRigidBody = proj.GetComponent<Rigidbody>();
        var force = 2000.0f;
        var cannonShooter = GameObject.Find("/Cannon/RotationPoint/CannonShooter").transform.position;
        var rotationPoint = GameObject.Find("/Cannon/RotationPoint").transform.position;
        Ray ray = new Ray(rotationPoint, cannonShooter - rotationPoint);
        myRigidBody.AddForce(ray.direction.normalized * force);
    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Shoot();
        }
    }
}
