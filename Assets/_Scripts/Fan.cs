using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
    public Transform toRotate;
    public float rotationSpeed;
    public float stoppingSpeed;
    float lifeTime;
    Rigidbody rb;
    Player player;

    private void Start()
    {
        player = FindObjectOfType<Player>();
        lifeTime = player.timeTillDisaster;
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (rotationSpeed > 0)
        {
            toRotate.Rotate(new Vector3(0, Time.deltaTime * rotationSpeed, 0));
            if (lifeTime < 0)
            {
                rotationSpeed -= Time.deltaTime * stoppingSpeed;
                rb.useGravity = true;
            }
            lifeTime -= Time.deltaTime;
        }
    }
}
