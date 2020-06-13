using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    private float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float y = -1f;

        Vector3 move = transform.right * x + transform.up * y + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
    }
   
}
