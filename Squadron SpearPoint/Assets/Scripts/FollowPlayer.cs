using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject SD_TigerI;
    private Vector3 offset = new Vector3(5, 10, -7);
    private Vector3 newPosition;

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
        

        transform.position = SD_TigerI.transform.position + offset;
        transform.rotation = SD_TigerI.transform.rotation;
    }
}

