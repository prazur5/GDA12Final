using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankControl : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turnSpeed = 180f;
    public Transform turretTransform;
    public Transform cannonTransform;
    public GameObject bulletPrefab;
    public float fireRate = 0.5f;
    private float fireTimer;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        transform.position += transform.forward * moveZ * moveSpeed * Time.deltaTime;
        transform.rotation *= Quaternion.AngleAxis(moveX * turnSpeed * Time.deltaTime, Vector3.up);

        float turnTurretX = Input.GetAxis("TurretHorizontal");
        float turnTurretY = Input.GetAxis("TurretVertical");
        turretTransform.rotation *= Quaternion.AngleAxis(turnTurretX * turnSpeed * Time.deltaTime, Vector3.up);
        cannonTransform.rotation *= Quaternion.AngleAxis(-turnTurretY * turnSpeed * Time.deltaTime, Vector3.right);

        if (Input.GetButton("Fire1"))
        {
            fireTimer += Time.deltaTime;
            if (fireTimer >= fireRate)
            {
                fireTimer = 0f;
                GameObject bullet = Instantiate(bulletPrefab, cannonTransform.position, cannonTransform.rotation);
                bullet.GetComponent<Rigidbody>().AddForce(cannonTransform.forward * 1000f);
            }
        }
    }
}
