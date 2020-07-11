using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{

    public TMP_Text text1;
    public Animator _animator;
    GameObject go;
    bool state;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            text1.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            text1.enabled = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                state = !state;
                text1.enabled = false;
                _animator.SetBool("open", state);

            }

        }


    }


    // Update is called once per frame

}