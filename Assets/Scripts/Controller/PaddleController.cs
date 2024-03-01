using UnityEngine;

public class PaddleController : MonoBehaviour
{
    [SerializeField] private KeyCode input;
    private float targetPressed, targetRelease;
    private HingeJoint hinge;
    private JointSpring jointSpring;
    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        targetPressed = hinge.limits.max;
        targetRelease = hinge.limits.min;
    }

    // Update is called once per frame
    private void Update()
    {
        ReadInput();
    }

    private void ReadInput(){
        jointSpring = hinge.spring;

        if (Input.GetKey(input))
        {
            jointSpring.targetPosition = targetPressed;
        } 
        else
        {
            jointSpring.targetPosition = targetRelease;
        }

        hinge.spring = jointSpring;
    }
}
