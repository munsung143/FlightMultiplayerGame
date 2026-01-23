using UnityEngine;

public class PlainMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotateSpeed;


    void Update()
    {
        Vector3 eularRotation = Vector3.zero;
        if (Input.GetKey(KeyCode.A)){ eularRotation.y--; }
        if (Input.GetKey(KeyCode.D)){ eularRotation.y++; }
        if (Input.GetKey(KeyCode.W)){ eularRotation.x--; }
        if (Input.GetKey(KeyCode.S)){ eularRotation.x++; }
        if (Input.GetKey(KeyCode.LeftArrow)){ eularRotation.z++; }
        if (Input.GetKey(KeyCode.RightArrow)){ eularRotation.z--; }
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.Self);
        transform.Rotate(eularRotation * rotateSpeed * Time.deltaTime, Space.Self);
    }
}
