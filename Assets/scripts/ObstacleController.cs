using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float posY=Random.Range(-5, 0);
        transform.position=new Vector3(15,posY,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left*0.05f);
    }
}
