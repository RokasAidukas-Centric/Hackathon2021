using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterWithRotation : MonoBehaviour
{
    private CharacterController controller;
    public float Speed = 3.0F;
    public float RotateSpeed = 3.0F;
    void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }

    void Update()
    {
        // controller = GetComponent<CharacterController>();
        if (transform != null)
        {
            transform.Rotate(0, Input.GetAxis("Horizontal") * RotateSpeed, 0);
            var forward = transform.TransformDirection(Vector3.forward);
            float curSpeed = Speed * Input.GetAxis("Vertical");
            controller.SimpleMove(forward * curSpeed);
        }
    }
}
