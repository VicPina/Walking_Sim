using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        chController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + CryptoAPITransform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
    }
   
}
