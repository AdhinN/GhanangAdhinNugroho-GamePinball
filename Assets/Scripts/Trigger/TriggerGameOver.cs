using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerGameOver : MonoBehaviour
{
    [SerializeField] private GameObject gameOverUI;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Bola")    
        {
            gameOverUI.SetActive(true);
        }
    }
}
