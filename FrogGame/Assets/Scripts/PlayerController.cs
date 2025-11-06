using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 movement;


    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        movement.x = inputX * speed * Time.deltaTime;

        transform.Translate(movement);
    }
}
