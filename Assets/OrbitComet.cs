using UnityEngine;
using System;

public class OrbitComet : MonoBehaviour
{
    public double gravity = 0.2;
    public Vector3 velocity = Vector3.zero;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        double distance = Math.Sqrt(
            Math.Pow(position.x, 2) +
            Math.Pow(position.y, 2) +
            Math.Pow(position.z, 2)
        );
        
        double ax = -gravity * position.x / Math.Pow(distance, 3);
        double ay = -gravity * position.y / Math.Pow(distance, 3);
        double az = -gravity * position.z / Math.Pow(distance, 3);

        velocity.x += (float)(ax * Time.deltaTime);
        velocity.y += (float)(ay * Time.deltaTime);
        velocity.z += (float)(az * Time.deltaTime);

        transform.position += velocity * Time.deltaTime;
    }
}
