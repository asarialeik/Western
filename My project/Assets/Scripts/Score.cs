using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score = 000;
    [SerializeField]
    TextMeshProUGUI scoreText;

    void ChangeScore()
    {
        scoreText.text = score.ToString("000");
    }
}
