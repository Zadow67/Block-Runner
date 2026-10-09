using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.PlayerLoop;
using UnityEngine.UIElements;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody playerBody;
    public float force = 1000f;
    public float speed = 10f;
    public float minX;
    public float maxX;

    // Start is called before the first frame update
    void Start()
    {

    }
    void Update()
    {
        Vector3 playerPos = transform.position;

        playerPos.x = Mathf.Clamp(playerPos.x, minX, maxX);
        transform.position = playerPos;

        if (Keyboard.current.rightArrowKey.isPressed) 
        {
            transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            transform.position = transform.position - new Vector3(speed * Time.deltaTime, 0, 0);
        }
    }
    private void FixedUpdate()
    {
        playerBody.AddForce(0, 0, force * Time.deltaTime);
    }
}

