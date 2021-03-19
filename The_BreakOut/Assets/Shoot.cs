using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    [SerializeField]
    private Transform GunTip;

    [SerializeField]
    private GameObject bullet;

    private Vector2 lookDirection;
    private float lookAngle;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, lookAngle - 90f);


        if (Input.GetMouseButtonDown(0))
        {
            FireBullet();
        }   
    }
    private void FireBullet()
    {
        GameObject firedBullet = Instantiate(bullet, GunTip.position, GunTip.rotation);
        //firedBullet.GetComponent<Rigidbody2D>.velocity = GunTip.up * 10f;



    }
}
