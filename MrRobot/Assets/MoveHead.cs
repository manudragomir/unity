using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHead : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Getting the ray formed by the camera and the mouse
        Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        // Create the front view plane
        Plane offsetedCameraPlane = new Plane(Camera.main.transform.forward, 4);

        float rayLength;
        if (offsetedCameraPlane.Raycast(cameraRay, out rayLength))
        {
            //Getting the point on the camera ray 
            Vector3 pointToLook = cameraRay.GetPoint(rayLength);
            
            // Debug.DrawLine(cameraRay.origin, pointToLook, Color.cyan);

            //Look at the point
            transform.LookAt(pointToLook);
        }
    }
}
