#pragma warning disable 0108
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform traget;
    [SerializeField] private Camera camera;

    private float smoothSpeed = 0.7f;
    [SerializeField] private Vector3 cameraOffset;

    private void FixedUpdate()
    {
        Vector3 desiredPosition = traget.position + cameraOffset;
        Vector3 smoothedPosition = Vector3.Lerp(camera.transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        camera.transform.position = smoothedPosition;
    }
}
