using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 4.0f;
    [SerializeField] private float rotationSpeed = 200.0f;

    private float horizontal;
    private float depth;

    private Vector3 moveDirection;
    private Quaternion rotationToMoveDirection;

    void Update()
    {
        //Debug.Log($"Move input: {depth} , {horizontal}");

        if (moveDirection != Vector3.zero)
        {
            Rotate();
        }
        Move();
    }

    private void Rotate()
    {
        Vector3 projectedCameraForward = Vector3.ProjectOnPlane(Camera.main.transform.forward, Vector3.up);
        Quaternion rotatioToCamera = Quaternion.LookRotation(projectedCameraForward, Vector3.up);

        moveDirection = rotatioToCamera * moveDirection;
        rotationToMoveDirection = Quaternion.LookRotation(moveDirection, Vector3.up);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, rotationToMoveDirection, rotationSpeed * Time.deltaTime);
    }

    private void Move()
    {
        moveDirection = Vector3.forward * depth + Vector3.right * horizontal;

        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
    public void OnMoveInput(float horizontal, float vertical)
    {
        //Z is actually as depth 
        this.depth = vertical;
        this.horizontal = horizontal;
    }
}
