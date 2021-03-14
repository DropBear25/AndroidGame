using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ThirdPersonPlayer : MonoBehaviour
{

    public FixedJoystick LeftJoystick;
    public PlayerButton Button;
    public TouchScreen TouchScreen;
    protected Player Control;

    protected float CameraAngle;
    protected float CameraAngleSpeed = 0.2f;


    void Start()
    {
        Control = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        CameraAngle += TouchScreen.TouchDist.x * CameraAngleSpeed;

        Camera.main.transform.position = transform.position + Quaternion.AngleAxis(CameraAngle, Vector3.up) * new Vector3(0, 3, 4);
        Camera.main.transform.rotation = Quaternion.LookRotation(transform.position + Vector3.up * 2f - Camera.main.transform.position, Vector3.up);
    }
   
}