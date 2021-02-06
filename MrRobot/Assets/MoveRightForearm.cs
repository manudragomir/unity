using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightForearm : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 80.0f;
    private const float minAngle = 0.0f;
    private const float maxAngle = 90.0f;
    private float angle = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;
        float dangle = speed * dt;

        if (angle + dangle < minAngle || angle + dangle > maxAngle)
        {
            speed *= -1.0f;
            dangle *= -1.0f;
        }

        angle += dangle;
        transform.Rotate(Vector3.right, dangle, Space.Self);
    }
}
