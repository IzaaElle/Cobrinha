using UnityEngine;

public class WallCollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
            gameManager.GameOver();

        }
    }



        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
