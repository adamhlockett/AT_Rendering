using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToggle : MonoBehaviour
{
    public GameObject sun;

    private Light sunLight;

    public float daylightIntensity;
    public float nightlightIntensity;

    private void Start()
    {
        sunLight = sun.GetComponent<Light>();
        sunLight.intensity = daylightIntensity;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            if(sunLight.intensity == daylightIntensity)
            {
                //daytime
                sunLight.intensity = nightlightIntensity;
                //Debug.Log("daytime");
            }
            else
            {
                //nightime
                sunLight.intensity = daylightIntensity;
                //Debug.Log("nighttime");
            }
        }
    }
}
