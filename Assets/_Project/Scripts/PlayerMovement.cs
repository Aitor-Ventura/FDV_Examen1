using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController _characterController;
    private float _speed = 5f;
    private Vector3 movementVector = Vector3.zero;
    
    private void Start()
    {
        _characterController = gameObject.AddComponent<CharacterController>().GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (_characterController.isGrounded)
        {
            movementVector = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            if (Input.GetKeyDown(KeyCode.Space))
            {
                movementVector.y = 5f;
            } 
        }
        movementVector.y -= Physics.gravity.magnitude * Time.deltaTime;
        _characterController.Move(movementVector * (_speed * Time.deltaTime));
    }
}
