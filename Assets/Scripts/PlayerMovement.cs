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
    private int coinAmount = 0;

    private void OnTriggerEnter(Collider collider)
    {
        Destroy(collider.gameObject);
        coinAmount = coinAmount + 1;
    }

    //private void OnCollsionExit(Collision collision)
    //{
    //}

    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();

        movementDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        movementDirection = transform.TransformDirection(movementDirection);

        movementDirection *= moveSpeed;

        movementDirection.y -= gravity * Time.deltaTime;

        controller.Move(movementDirection * Time.deltaTime);

        Debug.Log(coinAmount);

        if (coinAmount == 10)
        {
            SceneManager.LoadScene("End");
        }
    }
}
