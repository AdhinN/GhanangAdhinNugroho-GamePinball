using UnityEngine;

public class ZoomInController : MonoBehaviour
{
    [SerializeField] private CameraController cameraController;
    [SerializeField] private float length;
    [SerializeField] private Collider bola;


    private void OnTriggerEnter(Collider collider) 
    {
        if (collider == bola)
        {
            cameraController.FollowTarget(bola.transform, length);
        }
    }
}
