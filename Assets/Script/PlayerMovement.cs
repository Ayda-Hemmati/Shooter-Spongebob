using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float walkspeed = 4f;

    public float maxVelocityChange = 10f;

    public float sprintspeed = 14f;
    

    [Space]
    public float jumpheight = 5f;

    private Vector2 input;

    private Rigidbody rb;

    private bool sprinting;

    private bool jumping;

    private bool grounded = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

       
    }

    // Update is called once per frame
    void Update()
    {
        input=new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));

        input.Normalize();

        sprinting = Input.GetButton("Sprint");

        jumping = Input.GetButton("Jump");


    }

    private void OnTriggerStay(Collider other){

        grounded = true;
    }

     void FixedUpdate(){

        if(grounded){
            if(jumping){
                rb.velocity = new Vector3(rb.velocity.x,jumpheight,rb.velocity.z);
            }
        }
        rb.AddForce(CalculateMovement(sprinting ? sprintspeed : walkspeed), ForceMode.VelocityChange);
        grounded = false;
     }

        Vector3 CalculateMovement(float _speed){

        Vector3 targetVelocity = new Vector3(input.x,0,input.y);

        targetVelocity = transform.TransformDirection(targetVelocity);

        targetVelocity *=_speed;

        Vector3 velocity = rb.velocity;

        if(input.magnitude > 0.5f){

            Vector3 velocityChange=targetVelocity - velocity;

            velocityChange.x=Mathf.Clamp(velocityChange.x,-maxVelocityChange,maxVelocityChange);

            velocityChange.z=Mathf.Clamp(velocityChange.z,-maxVelocityChange,maxVelocityChange);

            velocityChange.y=0;

            return(velocityChange);
        }
        else{
            return new Vector3();
        }

    }
}
