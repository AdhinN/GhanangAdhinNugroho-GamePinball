using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    private enum SwitchState
    {
        On,
        Off,
        Blink
    }

    [SerializeField] private Material switchOff;
    [SerializeField] private Material switchOn;
    [SerializeField] private float score;
    public ScoreManager scoreManager;
    public VFXManager vfxManager;
    public AudioManager audioManager;
    private SwitchState state;
    private Renderer rend;

    private void Start() 
    {
        rend = GetComponent<Renderer>();

        SetSwitch(false);   

        StartCoroutine(BlinkTimerStart(5));
    }

    private void OnTriggerEnter(Collider collider) 
    {
        if (collider.tag == "Bola")
        {   
            Toogle();
        }
    }

    private void SetSwitch(bool active)
    {
        //rend.material = active ? switchOn : switchOff;
        if(active == true)
        {
            state = SwitchState.On;
            rend.material = switchOn;
        }
        else
        {
            state = SwitchState.Off;
            rend.material = switchOff;
            StartCoroutine(BlinkTimerStart(5));
        }
    }

    private void Toogle()
    {
        if (state == SwitchState.On)
        {
            SetSwitch(false);
        }
        else
        {
            SetSwitch(true);
        }
        scoreManager.AddScore(score);
        vfxManager.PlayVFXSwitch(transform.position);
        audioManager.PlaySFXSwitch(transform.position);
    }

    private IEnumerator Blink(int times){
        state = SwitchState.Blink;

        for (int i = 0; i < times; i++)
        {
            rend.material = switchOn;
            yield return new WaitForSeconds(0.2f);
            rend.material = switchOff;
            yield return new WaitForSeconds(0.2f);
        }

        state = SwitchState.Off;
        StartCoroutine(BlinkTimerStart(5));
    }

    private IEnumerator BlinkTimerStart(int time){
        yield return new WaitForSeconds(time);
        StartCoroutine(Blink(2));
    }
}
