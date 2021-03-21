using System.Collections;
using UnityEngine;


public class GunJoystick : MonoBehaviour
{


    public Joystick joystick;


 


    void Update()
    {
        Vector3 moveVector = (Vector3.up * joystick.Horizontal + Vector3.left * joystick.Vertical);
        if(joystick.Horizontal != 0 || joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(Vector3.forward, moveVector);
        }


    }

}