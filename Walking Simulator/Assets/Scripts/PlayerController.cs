using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;
    public float rotationSpeed = 100;
       
    private Vector3 movement = Vector3.zero;
    private Vector3 rotation = Vector3.zero;

    private CharacterController chController;

    // Start is called before the first frame update
    void Start()
    {
        chController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
    }
    public void FixedUpdate()
    {
        chController.Move(movement * Time.deltaTime * speed);
    }
}
