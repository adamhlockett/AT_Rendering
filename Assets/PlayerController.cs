using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            this.GetComponent<Transform>().position += Vector3.forward;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            this.GetComponent<Transform>().position += Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            this.GetComponent<Transform>().position += Vector3.back;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            this.GetComponent<Transform>().position += Vector3.right;
        }
    }
}
