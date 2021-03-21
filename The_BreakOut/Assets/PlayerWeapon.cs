using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerWeapon : MonoBehaviour
{

    [SerializeField]
    float moveSpeed = 2f;

    [SerializeField]
    float bulletSpeed = 5f;

    [SerializeField]
    Transform gun;
    [SerializeField]
    Rigidbody2D bullet;


    private Transform aimTransform;

    //test

   




    private void Awake(){

      //  aimTransform = transform.Find("Aim");
    }



    // Update is called once per frame
    void Update()
    {

        HandleAiming();
        /*   HandleShooting();  //Michelle Rotation Script Mouse Position to rotate Gun 

            Vector3 mousePosition = UtilsClass.GetMouseWorldPosition();
            Vector3 aimDirection = (mousePosition - transform.position).normalized;
            float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;
            aimTransform.eulerAngles = new Vector3(0, 0, angle);
            Debug.Log(angle);
        }

    */
    }
        private void HandleAiming()
    {

    }

    private void HandleShooting()
    {

        if (CrossPlatformInputManager.GetButtonDown("Fire1"))
        {
            var firedBullet = Instantiate(bullet, gun.position, gun.rotation);
            firedBullet.AddForce(gun.up * bulletSpeed);


        }

    }
}
