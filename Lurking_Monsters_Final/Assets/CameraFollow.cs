using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] public Transform target;

    private void LateUpdate()
    {
        transform.position = target.position;
    }
}

