using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanRotation : MonoBehaviour
{
    [Tooltip("Max rotation speed")]
    public float maxRotationSpeed = 500f; // Maximum speed in degrees per second
    [Tooltip("Acceleration of rotation")]
    public float acceleration = 50f; // Speed change in degrees per second squared
    private float currentSpeed = 0f;
    private bool isOn = false;

    void Update()
    {
        float targetSpeed = isOn ? maxRotationSpeed : 0f;
        currentSpeed = Mathf.MoveTowards(currentSpeed, targetSpeed, acceleration * Time.deltaTime);
        transform.Rotate(transform.up, currentSpeed * Time.deltaTime);
    } 

    public void ChangeState()
    {
        isOn = !isOn;
    }
}