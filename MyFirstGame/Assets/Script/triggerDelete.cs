using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerDelete  : MonoBehaviour
{
    public GameObject _object;
    public bool _enter, _exit;
   
    private void OnTriggerEnter(Collider other)
    {
       
        _object.SetActive(_enter);
    }
    private void OnTriggerExit(Collider other)
    {
        _object.SetActive(_exit);
    }

}
