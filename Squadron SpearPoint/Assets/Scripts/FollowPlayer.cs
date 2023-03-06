using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Target;
    //private Vector3 offset = new Vector3(0, 9, -17);
    //private Vector3 newPosition;
    public float position = 0.2f;
    public float rotation = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, Target.position, position);
        transform.rotation = Quaternion.Lerp(transform.rotation, Target.rotation, rotation);
    }

    void LateUpdate()
    {
        

        //transform.position = Target.transform.position + offset;
        //transform.rotation = Target.transform.rotation;
    }
}

