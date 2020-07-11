using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CHEST_NUMBER : MonoBehaviour
{

    public TMP_Text text_chests, win_text;
    public int score, maxCountChests ;
    int oldScore;
    public int sceneIndex;

    private void Update()
    {
        if (score != oldScore)
        {
            text_chests.text = $"CHESTS: {score} /  3";
            oldScore = score;
        }
        if (score == 3)
        {
            win_text.enabled = true;
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
