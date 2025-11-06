using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 moveInput;


    void Update()
    {
        float inputX = 0f;

        if (Keyboard.current.leftArrowKey.isPressed)
            inputX = -1f;
        else if(Keyboard.current.rightArrowKey.isPressed)
            inputX = 1f;

        Vector3 movement = new Vector3(inputX, 0, 0) * speed * Time.deltaTime;
        transform.Translate(movement);
    }
}
