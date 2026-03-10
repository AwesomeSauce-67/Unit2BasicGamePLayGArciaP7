using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GameManaager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager =
            GameObject.Find("GameManager").GetComponent<GameManaager>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           Destroy(gameObject);
            Debug.Log("Game Over");
        }
        else if (other.CompareTag("Projectile"))
        {
            gameManager.AddScore(5);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        
    }
}
