using System.Data.Common;
using Unity.VisualScripting;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    [SerializeField] private Collider bola;
    [SerializeField] private float multiplier;
    [SerializeField] private Color color;
    private Renderer rend;
    private Animator anim;
    public AudioManager audioManager;
    public VFXManager vfxManager;
    public ScoreManager scoreManager;
    [SerializeField] private float score;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        anim = GetComponent<Animator>();
        rend.material.color = color;    
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;

            rend.material.color = Random.ColorHSV();
            anim.SetTrigger("hit");

            //sfx
            audioManager.PlaySFXBumper(collision.transform.position);

            //vfx
            vfxManager.PlayVFXBumper(collision.transform.position);

            //tambah skor
            scoreManager.AddScore(score);
        }
    }
}
