using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   public float walkspeed = 3f;

    [Space]

    private Vector2 input;

    private Rigidbody rb;

    public float health =100f;

// Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

       
    }

    
    public void TakeDamage(float damage){

        health -= damage;

        if(health<=0){

            Die();
        }
    }

    private void Die(){

        Destroy(gameObject);
    }
}
