using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turnSpeed = 50f;

    private Vector2 moveInput;
    private float turnInput;

    private Rigidbody tankRigidbody;

    private void Start()
    {
        tankRigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float moveX = moveInput.x;
        float moveZ = moveInput.y;

        Vector3 movement = transform.right * moveX + transform.forward * moveZ;
        tankRigidbody.AddForce(movement * moveSpeed);

        float turn = turnInput * turnSpeed * Time.deltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        tankRigidbody.MoveRotation(tankRigidbody.rotation * turnRotation);
    
    }
}
