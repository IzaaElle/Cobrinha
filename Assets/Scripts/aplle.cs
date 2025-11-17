using UnityEngine;
using Unity.Mathematics;

public class aplle : MonoBehaviour
{
    [SerializeField]
    float xLimit = 16.0f;
    [SerializeField]
    float yLimit = 8.5f;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(UnityEngine.Random.Range (-xLimit, xLimit), UnityEngine.Random.Range(-yLimit, yLimit), 0);
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") 
        {
            other.gameObject.transform.parent.GetComponent<MiniSnake>().AddTail();

            transform.position = new Vector3(UnityEngine.Random.Range(-xLimit, xLimit), UnityEngine.Random.Range(-yLimit, yLimit), 0);
                      
        }
    }
}


