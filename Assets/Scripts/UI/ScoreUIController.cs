using TMPro;
using UnityEngine;

public class ScoreUIController : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    public ScoreManager scoreManager;

    private void Update() 
    {
        scoreText.text = scoreManager.score.ToString();    
    }
}
