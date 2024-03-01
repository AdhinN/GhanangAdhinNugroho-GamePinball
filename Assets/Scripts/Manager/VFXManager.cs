using UnityEngine;

public class VFXManager : MonoBehaviour
{
    [SerializeField] private GameObject vfxBumper;
    [SerializeField] private GameObject vfxSwitch;

    public void PlayVFXBumper(Vector3 spawnPosition)
    {
        GameObject.Instantiate(vfxBumper, spawnPosition, Quaternion.identity);
    }

    public void PlayVFXSwitch(Vector3 spawnPosition)
    {
        GameObject.Instantiate(vfxSwitch, spawnPosition, Quaternion.identity);
    }
}
