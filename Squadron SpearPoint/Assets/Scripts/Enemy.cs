using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //variables
    public float health;

    //methods
    public void Update()
    {
        if(health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        print("Enemy " + this.gameObject.name + " has died ");
        Destroy(this.gameObject);
    }

}
