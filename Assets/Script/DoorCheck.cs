using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCheck : MonoBehaviour
{
    
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("Door_opened", false);
    }

   private void OnTriggerEnter(Collider other)
   {
   if(other.tag=="Player"){
    animator.SetBool("Door_opened", true);
   }
   }

 private void OnTriggerExit(Collider other)
   {
   if(other.tag=="Player"){
    animator.SetBool("Door_opened", false);
   }
   }

}
