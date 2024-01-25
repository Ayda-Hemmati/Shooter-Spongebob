using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prison_Check : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("Prison_opened", false);
    }

    private void OnTriggerEnter(Collider other)
   {
   if(other.tag=="Player"){
    animator.SetBool("Prison_opened", true);
   }
   }
}
