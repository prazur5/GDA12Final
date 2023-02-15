using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Copy_Tankcontroller : MonoBehaviour
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

        float turnTurretX = Input.GetAxis("Horizontal");
        float turnTurretY = Input.GetAxis("Vertical");
        turretTransform.rotation *= Quaternion.AngleAxis(turnTurretX * turnSpeed * Time.deltaTime, Vector3.up);
        cannonTransform.rotation *= Quaternion.AngleAxis(-turnTurretY * turnSpeed * Time.deltaTime, Vector3.right);

        if (Input.GetKeyDown(KeyCode.Space))
        {

            //Delete the lines that are currently 31 and 32 if you run into issues and get rid of the double slashes to revert back to the code Chatgpt gave
            GameObject bullet = Instantiate(bulletPrefab, cannonTransform.position, cannonTransform.rotation);
            bullet.GetComponent<Rigidbody>().AddForce(cannonTransform.forward * 1000f);
            //fireTimer += Time.deltaTime;
            //if (fireTimer >= fireRate)
            //{
            //    fireTimer = 4f;
            //    GameObject bullet = Instantiate(bulletPrefab, cannonTransform.position, cannonTransform.rotation);
            //    bullet.GetComponent<Rigidbody>().AddForce(cannonTransform.forward * 1000f);
            //}
        }
    }




    
}

//Chatgpt tank code example!

