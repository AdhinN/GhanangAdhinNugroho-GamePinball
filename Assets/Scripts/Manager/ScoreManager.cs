using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public float score;

    private void Start() 
    {
        ResetScore();   
    }

    public void AddScore(float additionScore)
    {
        score += additionScore;
    }

    public void ResetScore()
    {
        score = 0;
    }
}
