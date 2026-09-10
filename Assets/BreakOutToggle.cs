using UnityEngine;
using UnityEngine.InputSystem;

public class BreakOutToggle : MonoBehaviour
{
    [Header("Input Action")]
    public InputActionReference toggleAction;

    [Header("Teleport Destinations")]
    public Transform roomPosition;
    public Transform externalPosition;

    [Header("Player Target")]
    public Transform playerTransform; 

    private bool isInRoom = true;

    private void OnEnable()
    {
        if (toggleAction != null)
        {
            toggleAction.action.Enable();
            toggleAction.action.performed += OnTogglePressed;
        }
    }

    private void OnTogglePressed(InputAction.CallbackContext context)
    {
        if (playerTransform == null || roomPosition == null || externalPosition == null)
            return;

        if (isInRoom)
        {
            playerTransform.position = externalPosition.position;
            playerTransform.rotation = externalPosition.rotation;
            isInRoom = false;
        }
        else
        {
            playerTransform.position = roomPosition.position;
            playerTransform.rotation = roomPosition.rotation;
            isInRoom = true;
        }
    }

    private void Disable()
    {
        if (toggleAction != null)
        {
            toggleAction.action.performed -= OnTogglePressed;
            toggleAction.action.Disable();
        }
    }
}