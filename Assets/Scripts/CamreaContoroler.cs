using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamreaContoroler : MonoBehaviour
{
    public float MouseSensitivity = 300f;
    public float XRotation;
    public Transform body;

  void Start()
    {
       
    }
    void Update()
    {
        float MouseX = Input.GetAxis("Mouse X") * MouseSensitivity * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * MouseSensitivity * Time.deltaTime;

        XRotation = Mathf.Clamp(XRotation, -80f, 45f);

        body.Rotate(Vector3.up * MouseX);   

        XRotation -= MouseY;

        transform.localRotation = Quaternion.Euler(XRotation, 0f, 0f);
    }
}
