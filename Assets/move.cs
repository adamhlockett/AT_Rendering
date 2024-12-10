using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField] private float _speed = 1;
    //[SerializeField] private Rigidbody _rb;
    [SerializeField] float sens = 5;

    CharacterController _characterController;

    Vector2 rotation = Vector2.zero;
    Vector3 velocity = Vector3.zero;

    // Update is called once per frame

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        _characterController = GetComponent<CharacterController>();
    }
    void Update()
    {
        var gravity = Physics.gravity * 400 * Time.deltaTime;
        velocity.y = _characterController.isGrounded ? -1f : velocity.y * gravity.y;

        //Debug.Log(_characterController.isGrounded);



        rotation.x += Input.GetAxis("Mouse X") * sens;
        rotation.y += Input.GetAxis("Mouse Y") * sens;
        rotation.y = Mathf.Clamp(rotation.y, -88f, 88f);
        var xQuaternion = Quaternion.AngleAxis(rotation.x, Vector3.up);
        var yQuaternion = Quaternion.AngleAxis(rotation.y, Vector3.left);

        transform.localRotation = xQuaternion * yQuaternion;

        //var dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //
        //_rb.velocity = dir * _speed;

        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");

        var input = new Vector3();
        input += transform.forward * y;
        input += transform.right * x;
        input = Vector3.ClampMagnitude(input, 1f);

        //transform.Translate(input * 5f * Time.deltaTime, Space.World);
        _characterController.Move((input * 5f + velocity) * Time.deltaTime);

    }
}
