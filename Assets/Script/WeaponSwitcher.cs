using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitcher : MonoBehaviour
{
 
   
    private int SelectedWeapon = 0;

    // Start is called before the first frame update
    void Start()
    {
        SelectWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        int previousSelectedWeapon = SelectedWeapon;

        if(Input.GetKeyDown(KeyCode.Alpha1)){
            SelectedWeapon = 0;
        }
        if(Input.GetKeyDown(KeyCode.Alpha2)){
            SelectedWeapon = 1;
        }

        if(previousSelectedWeapon != SelectedWeapon){
            SelectWeapon();
        }
    }

    void SelectWeapon(){
    int i = 0;
    foreach(Transform _Weapon in transform){
       if(i == SelectedWeapon){
            _Weapon.gameObject.SetActive(true);
        }
      else{
            _Weapon.gameObject.SetActive(false);
       }
        i++;
    }
    
   }
}
