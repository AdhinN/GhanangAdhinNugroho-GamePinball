using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class TriggerRampController : MonoBehaviour
{
    [SerializeField] private float score;
    public ScoreManager scoreManager;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Bola")    
        {
            //tambah skor
            scoreManager.AddScore(score);
        }
    }
}
