using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayersBehavior : MonoBehaviour
{
    [SerializeField]
    GameObject[] targets;
    [SerializeField]
    GameObject[] targetPositions;
    private GameObject spawningTargetPositionChosen;
    private GameObject newTarget;
    public float spawnTimer = 0;
    public int spawnTime = 7;
    public int spawningTarget;
    public int targetPositionObject;
    public Vector2 xPosition;

    void Start()
    {
        gameObject.SetActive(false);
    }

    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnTime)
        {
            spawnTimer = 0;
            spawningTarget = Random.Range(0, targets.Length);
            targets[spawningTarget].SetActive(true);
            spawnTime = Random.Range(5, 10);
        }
    }
}
