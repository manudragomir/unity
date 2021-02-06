 using UnityEngine;
 using System.Collections;
 
 [RequireComponent(typeof(CharacterController))]
 public class MovePlayer : MonoBehaviour
 {
     public float Speed = 2.0F;
     public float RotateSpeed = 1.0F;
     void Update()
     {
         CharacterController controller = GetComponent<CharacterController>();
         if (transform != null)
         {
             transform.Rotate(0, Input.GetAxis("Horizontal") * RotateSpeed, 0);
             var forward = transform.TransformDirection(Vector3.forward);
             float curSpeed = Speed * Input.GetAxis("Vertical");
             controller.SimpleMove(forward * curSpeed);
         }
     }
 }