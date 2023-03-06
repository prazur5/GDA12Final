using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraGPT : MonoBehaviour
{
    public Transform player;
    //public float cameraOffset = 10f;
    private Vector3 offset = new Vector3(0, 9, -17);
    public float cameraSpeed = 5f;
    public GameObject SD_TigerI;
    void Start()
    {
        if (player == null)
        {
            Debug.LogError("Player object not assigned to camera!");
        }
    }

    void LateUpdate()
    {

        transform.position = SD_TigerI.transform.position + offset;
        //Vector3 targetPosition = player.position - player.forward * cameraOffset;
        Quaternion targetRotation = Quaternion.LookRotation(player.position - transform.position, player.up);

        //transform.position = Vector3.Lerp(transform.position, targetPosition, cameraSpeed * Time.deltaTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, cameraSpeed * Time.deltaTime);
    }
}

    

