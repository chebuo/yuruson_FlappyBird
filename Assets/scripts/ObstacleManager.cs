using System.Collections;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject obstacle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnObstacle());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnObstacle()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.5f);
            Instantiate(obstacle);
        }
    }
}
