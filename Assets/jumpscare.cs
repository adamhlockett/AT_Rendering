using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class jumpscare : MonoBehaviour
{
    public Transform enemyTransform;
    public Transform finishPoint;
    bool on = false;
    public float speed;

    private void OnTriggerEnter(Collider other)
    {
        on = true;
    }

    private void Update()
    {
        if (!on) return;

        //Debug.Log("moving");
        enemyTransform.position = Vector3.MoveTowards(enemyTransform.position, finishPoint.position, speed * Time.deltaTime);/*new Vector3((enemyTransform.position.x + 1) * speed * Time.deltaTime, enemyTransform.position.y, enemyTransform.position.z)*/;
    }
}
