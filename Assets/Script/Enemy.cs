using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   //public float walkspeed = 3f;

    Animator animator;


// Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("Die_check", true);
       
    }

    private void OnTriggerEnter(Collider other)
   {
    
   if(other.tag=="Player"){
    animator.SetBool("Die_check", true);
   }
   

   }
}
