using UnityEngine;
using UnityEngine.InputSystem;

public class ObjectSpawner : MonoBehaviour
{
    [Header("Input Action")]
    public InputActionReference spawnAction;

    [Header("Prefabs")]
    public GameObject objectToSpawn;      
    public GameObject particleBurstPrefab; 

    [Header("Spawn Location")]
    public Transform spawnPoint; 

    void Start()
    {
        if (spawnAction != null)
        {
            spawnAction.action.Enable();
            spawnAction.action.performed += OnSpawnPressed;
        }
    }

    private void OnSpawnPressed(InputAction.CallbackContext context)
    {
        Vector3 location = spawnPoint != null ? spawnPoint.position : transform.position;
        Quaternion rotation = spawnPoint != null ? spawnPoint.rotation : transform.rotation;

        if (objectToSpawn != null)
        {
            Instantiate(objectToSpawn, location, rotation);
        }

        if (particleBurstPrefab != null)
        {
            Instantiate(particleBurstPrefab, location, rotation);
        }
    }

    private void OnDestroy()
    {
        if (spawnAction != null)
        {
            spawnAction.action.performed -= OnSpawnPressed;
        }
    }
}