using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public audioController _audioController;
    public Coins_number _score;
    private void OnTriggerStay(Collider other)
    {
       
        if (other.tag == "Player")
        {

            //  _audioController._audioSource.clip = _audioController._audioCoin;
            //  _audioController._audioSource.Play();
            _audioController._audioSource.PlayOneShot(_audioController._audioCoin);
            _score.score++;
            Destroy(gameObject);


            

        }
    }
  
  
}
