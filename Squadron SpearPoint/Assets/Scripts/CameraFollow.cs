using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float cameraOffset = 10f;
    public float cameraSpeed = 5f;

    private Vector3 targetPosition;

    void Start()
    {
        if (player == null)
        {
            Debug.LogError("Player object not assigned to camera!");
        }
    }

    void Update()
    {
        targetPosition = new Vector3(transform.position.x, transform.position.y, player.position.z - cameraOffset);

        transform.position = Vector3.Lerp(transform.position, targetPosition, cameraSpeed * Time.deltaTime);
    }
}

