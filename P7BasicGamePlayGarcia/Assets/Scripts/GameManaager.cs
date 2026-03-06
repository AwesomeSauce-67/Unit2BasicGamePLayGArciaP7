using UnityEngine;

public class GameManaager : MonoBehaviour
{
    private int score = 0;
    private int lives = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddLives(int value)
    {
        lives += value;

        if (lives <= 0)
        {
            lives = 0;
            Debug.Log("GameOver");
        }
        Debug.Log("Lives= "+lives);
    }

    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score= "+score);
      
    }
}
