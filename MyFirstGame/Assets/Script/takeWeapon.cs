using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeWeapon : MonoBehaviour
{
    
    public GameObject _gun;
    //public  gun_control;
    public void OnTriggerEnter(Collider other)
    {
       // gun_control.enable = true;
        _gun.SetActive(true);
        Destroy(gameObject);
    }

}
