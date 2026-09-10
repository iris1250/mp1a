using UnityEngine;
using UnityEngine.InputSystem;

public class LightController : MonoBehaviour
{
    public InputActionReference action;
    private Light pointLight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pointLight = GetComponent<Light>();
        
    }
    public void Pressed(InputAction.CallbackContext context){
        ChangeColor();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)) {
            ChangeColor();
        }
        
    }
    void ChangeColor() {
        if (pointLight.color == Color.white) {
            pointLight.color = Color.orange;
        } else {
            pointLight.color = Color.white;
        }
    }
}
