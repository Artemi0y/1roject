using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KEYS_NUMBER : MonoBehaviour
{
 
    public TMP_Text text_keys, win_text;
    public int score, maxCountKeys;
    int oldScore;
    [SerializeField] private GameObject _obj;
        
    
    private void Update()
    {
        if (score!=oldScore)
        {
            text_keys.text = $"KEYS: {score} / {maxCountKeys}";
            oldScore = score;
        }
        if (score == maxCountKeys)
        {
            win_text.enabled = true;
            Destroy(_obj);

            
        }
    }
}
