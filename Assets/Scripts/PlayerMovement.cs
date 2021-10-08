//Base script was made in Lab 1 from Social and Multiplayer Game Design

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 15.0F;
    private Vector3 movementDirection = Vector3.zero;

    void Start()
    {
    }

    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();

        //if (controller.isGrounded)
        //{
            movementDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            movementDirection = transform.TransformDirection(movementDirection);

            movementDirection *= moveSpeed;

            //if (Input.GetButton("Jump"))
                //movementDirection.y = jumpSpeed;
        //}

        //if (Input.GetKeyDown(KeyCode.Backspace))
        //{
            //SceneManager.LoadScene("Assign1Scene");
        //}

        movementDirection.y -= gravity * Time.deltaTime;

        controller.Move(movementDirection * Time.deltaTime);
    }
}
