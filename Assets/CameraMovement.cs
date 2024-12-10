using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float sens = 100f;

    public CharacterController contr;

    public Transform body;

    public float speed = 12f;

    float xRot = 0f;

    Vector3 vel = Vector3.zero;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        //body = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sens * Time.deltaTime;

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        

        Vector3 move = transform.right * x + transform.forward * z;

        contr.Move(move * speed * Time.deltaTime);

        xRot -= mouseY;
        //xRot = Mathf.Clamp(xRot, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
        body.Rotate(Vector3.up * mouseX);

            //if (Input.GetKey(KeyCode.Space))
            //{
            //    vel.y = speed * 0.05f;
            //}
            //else if (Input.GetKey(KeyCode.LeftControl))
            //{
            //    vel.y = -speed * 0.05f;
            //}
            //else
            //{
            //    vel.y = 0f;
            //}
            contr.Move(vel * speed * Time.deltaTime);
    }
}
