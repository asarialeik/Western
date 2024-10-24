using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SingularPlayerBehavior : MonoBehaviour
{
    [SerializeField]
    int maxTimeActive;
    public float activeTimer;
    public int scorePoints;

    void Start()
    {
        gameObject.SetActive(false);
    }

    void Update()
    {
        activeTimer += Time.deltaTime;
        if (activeTimer > maxTimeActive)
        {
                gameObject.SetActive(false);
        }
    }
}
