using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlight : MonoBehaviour
{

    public GameObject flashlightRef;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if(flashlightRef.activeSelf == true) { flashlightRef.SetActive(false); }
            else { flashlightRef.SetActive(true); }
        }
    }
}
