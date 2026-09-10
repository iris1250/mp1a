using UnityEngine;

public class RotatePlanet : MonoBehaviour
{
    private float rotationSpeed = 30f;

    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}