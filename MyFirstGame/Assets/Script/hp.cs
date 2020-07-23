using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class hp : MonoBehaviour
{
    public Slider life;
    public GameObject player;

    IEnumerator LifeCount()
    {
       
        while (life.value > 0)
            {
            yield return new WaitForSeconds(2f);
            life.value -= 0.01f;
        }
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //StartCoroutine(LifeCount());
            //life.value -= 0.1f;
        }

    }
    public void OnTriggerExit(Collider other)
    {
        //StopCoroutine(LifeCount());
    }
    public void OnTriggerStay(Collider other)
    {
        if (life.value > 0)
            life.value -= Time.deltaTime;
        else
        {
            Time.timeScale = 0;

        }
            

    }
}
