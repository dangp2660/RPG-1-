using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    [SerializeField] private GameObject spawnPrefab;
    [SerializeField] private float radius = 1f;
    [SerializeField] private Vector2 spawnMinPosition;
    [SerializeField] private Vector2 spawnMaxPosition;
    [SerializeField] private float spawnTime = 0f;   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnOject()
    {
        float randomX = Random.Range(spawnMinPosition.x, spawnMaxPosition.x);
        float randomY = Random.Range(spawnMinPosition.y, spawnMaxPosition.y);
        Vector2 vector2 = new Vector2(randomX, randomY);
        Instantiate(spawnPrefab, vector2, Quaternion.identity);
    }
}
