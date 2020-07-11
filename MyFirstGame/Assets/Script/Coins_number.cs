using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coins_number : MonoBehaviour
{

    public TMP_Text text_coins;
    public int score;
    int oldScore;
  

    private void Update()
    {
        if (score != oldScore)
        {
            text_coins.text = $"Coins: {score} ";
            oldScore = score;
        }
       
    }
}
