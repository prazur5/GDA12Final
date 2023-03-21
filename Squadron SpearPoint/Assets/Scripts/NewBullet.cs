using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBullet : MonoBehaviour
{
    public float speed = 40.0f;
    //public GameObject bullet;
    // Start is called before the first frame update
    public float damage;
    private GameObject triggeringEnemy;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //if (Vector3.Distance(transform.position, bullet.transform.position) > 20)
            //Destroy(bullet);

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);

        if(other.tag == "Bullet")
        {
            triggeringEnemy = other.gameObject;
            triggeringEnemy.GetComponent<Enemy>().health -= damage;
        }
    }

    
}
