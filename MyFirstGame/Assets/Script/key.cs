using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class key : MonoBehaviour
{
    public TMP_Text text_1;
    public KEYS_NUMBER _score;
    public audioController _audioController;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player") 
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
               // _audioController._audioSource.clip = _audioController._audioKey;
               // _audioController._audioSource.Play();

                _audioController._audioSource.PlayOneShot(_audioController._audioKey);
                text_1.enabled = false;
                _score.score++;
                Destroy(gameObject);


            }
           
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            text_1.enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {

            text_1.enabled = false;
        }
    }


}