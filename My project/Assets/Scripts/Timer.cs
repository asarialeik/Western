using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float remainingTime = 60;
    [SerializeField]
    TextMeshProUGUI timer;
    [SerializeField]
    GameObject endScreen;

    private void Start()
    {
        gameObject.SetActive(false);
    }
    void Update()
    {
        remainingTime -= Time.deltaTime;
        if (remainingTime <= 0 )
        {
            endScreen.SetActive(true);
            timer.text = "00";
        }
        else
        {
            timer.text = remainingTime.ToString("00");
        }
    }
}
