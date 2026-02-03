using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    [SerializeField] private float rotateSpeed;
    [SerializeField] private Vector2 mouseSensitivity;
    [SerializeField] Transform target;
    private Vector2 rotation;

    void Update()
    {
        rotation.x += Input.GetAxis("Mouse X") * mouseSensitivity.x;
        rotation.y -= Input.GetAxis("Mouse Y") * mouseSensitivity.y;
        transform.rotation = Quaternion.Euler(rotation.y, rotation.x, 0f);
    }
    void LateUpdate()
    {
        if (target != null) transform.position = target.position;
    }
}