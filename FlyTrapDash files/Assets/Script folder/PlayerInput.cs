using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    public Rigidbody2D rb;

    public float moveSpeed;

    private Vector2 _moveDirection;

    // Start is called before the first frame update
   /* void Start()
    {
        
    }*/

    public InputActionReference move;

    // Update is called once per frame
    private void Update()
    {
        _moveDirection = move.action.ReadValue<Vector2>();
    }

    private void FixedUpdate() {
        rb.velocity = new Vector2(_moveDirection.x * moveSpeed, _moveDirection.y * moveSpeed);
    }
}
