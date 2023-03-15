using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectOff : MonoBehaviour
{
    private float topbound = 600;
    private float rightbound = 600;
    private float leftbound = -600;
    private float lowerbound = -600;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topbound)
        {
            Destroy(gameObject);
            
        }else if(transform.position.z < lowerbound)
        {
            Destroy(gameObject);
        }
    }
}
