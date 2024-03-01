using UnityEngine;

public class ZoomOutController : MonoBehaviour
{
    [SerializeField] private CameraController cameraController;

    private void OnTriggerEnter(Collider collider) 
    {
        if (collider.tag == "Bola")
        {
            cameraController.GoBackToDefault();
        }
    }
}
