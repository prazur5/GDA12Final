using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject SD_TigerI;
    private Vector3 offset = new Vector3(0, 19, -18);
    public float moveSpeed = 5f;
    public float turnSpeed = 180f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {

        
        float moveZ = Input.GetAxis("Vertical");
        transform.position += transform.forward * moveZ * moveSpeed * Time.deltaTime;
        

        transform.position = SD_TigerI.transform.position + offset;
    }
}

