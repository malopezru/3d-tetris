using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    private Vector2 turn;
    private Vector2 move;
    public float rotationSensitivity = .5f;
    public float positionSensitivity = .2f;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            turn.x += Input.GetAxis("Mouse X") * rotationSensitivity;
            turn.y += Input.GetAxis("Mouse Y") * rotationSensitivity;
            transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
        }
        if (Input.GetMouseButton(1))
        {
            move.x += Input.GetAxis("Mouse X") * positionSensitivity;
            move.y += Input.GetAxis("Mouse Y") * positionSensitivity;
            transform.position = new Vector3(move.x, 12, move.y);
        }
    }
}
