using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float maxSpeed;
    private Rigidbody rg;
    // Start is called before the first frame update
    private void Start()
    {
        rg = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (rg.velocity.magnitude > maxSpeed)
        {
            rg.velocity = rg.velocity.normalized * maxSpeed;
        }
    }
}
