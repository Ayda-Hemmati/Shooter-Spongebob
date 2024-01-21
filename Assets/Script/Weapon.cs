using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float damage = 10f;
    public float range = 150f;
    
    public Camera cam;

    public ParticleSystem MuzzleFlash;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        
    }

    private void Shoot(){

         MuzzleFlash.Play();

        RaycastHit hit;
        
       if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range));
       {
        //print(hit.transform.name);

       // Enemy enemy = hit.transform.GetComponent<Enemy>();

       }
    }
}
