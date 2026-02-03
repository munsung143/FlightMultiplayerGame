using UnityEngine;

public class PlainMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    
    //z, x, y 순서
    [SerializeField] private float rotateSpeedRoll;
    [SerializeField] private float rotateSpeedPitch;
    [SerializeField] private float rotateSpeedYaw;



    void Update()
    {
        Vector3 eularRotation = Vector3.zero;
        if (Input.GetKey(KeyCode.A)){ eularRotation.y--; }
        if (Input.GetKey(KeyCode.D)){ eularRotation.y++; }
        if (Input.GetKey(KeyCode.W)){ eularRotation.x--; }
        if (Input.GetKey(KeyCode.S)){ eularRotation.x++; }
        if (Input.GetKey(KeyCode.Q)){ eularRotation.z++; }
        if (Input.GetKey(KeyCode.E)){ eularRotation.z--; }
        eularRotation.z *= rotateSpeedRoll;
        eularRotation.x *= rotateSpeedPitch;
        eularRotation.y *= rotateSpeedYaw;
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.Self);
        transform.rotation *= Quaternion.Euler(eularRotation * Time.deltaTime);
    }
}
