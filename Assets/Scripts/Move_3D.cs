using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_3D : MonoBehaviour
{
    public float speed = 10;
    private Rigidbody _ridigbody;
    private Camera _camera; 

    // Start is called before the first frame update
    void Start()
    {
        _ridigbody = GetComponent<Rigidbody>();
        _camera = transform.Find("Camera").GetComponent<Camera>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 2 * Input.GetAxis("Mouse X"), 0);
        Vector3 movement = new Vector3(speed * Input.GetAxis("Horizontal"), 0, speed * Input.GetAxis("Vertical"));
        _ridigbody.velocity =  transform.rotation * movement;
        _camera.transform.Rotate(-Input.GetAxis("Mouse Y"), 0, 0);
    }
}
