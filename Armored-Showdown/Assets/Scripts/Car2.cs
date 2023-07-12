using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car2 : MonoBehaviour
{
    [SerializeField] WheelCollider frontLeftWheelCollider, frontRightWheelCollider, rearLeftWheelCollider, rearRightWheelCollider;
    [SerializeField] float torque;
    [SerializeField] private float angle;
    [SerializeField] private Transform frontLeftWheelTransform;
    [SerializeField] private Transform frontRightWheelTransform;
    [SerializeField] private Transform rearLeftWheelTransform;
    [SerializeField] private Transform rearRightWheelTransform;


    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            ApplyTorque(torque);
            ApplyBrake(0);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            ApplyTorque(-torque); // Aplica torque negativo para ir en reversa
            ApplyBrake(0);
        }
        else
        {
            ApplyTorque(0);
            ApplyBrake(torque);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            ApplySteerAngle(angle);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            ApplySteerAngle(-angle);
        }
        else
        {
            ApplySteerAngle(0);
        }
        UpdateSingleWheel(frontLeftWheelCollider, frontLeftWheelTransform);
        UpdateSingleWheel(frontRightWheelCollider, frontRightWheelTransform);
        UpdateSingleWheel(rearRightWheelCollider, rearRightWheelTransform);
        UpdateSingleWheel(rearLeftWheelCollider, rearLeftWheelTransform);
    }
    private void ApplyTorque(float torque)
    {
        frontRightWheelCollider.motorTorque = torque;
        rearRightWheelCollider.motorTorque = torque;
        frontLeftWheelCollider.motorTorque = torque;
        rearLeftWheelCollider.motorTorque = torque;
    }

    private void ApplyBrake(float brakeTorque)
    {
        frontRightWheelCollider.brakeTorque = brakeTorque;
        rearRightWheelCollider.brakeTorque = brakeTorque;
        frontLeftWheelCollider.brakeTorque = brakeTorque;
        rearLeftWheelCollider.brakeTorque = brakeTorque;
    }

    private void ApplySteerAngle(float steerAngle)
    {
        frontLeftWheelCollider.steerAngle = steerAngle;
        frontRightWheelCollider.steerAngle = steerAngle;
    }
    private void UpdateSingleWheel(WheelCollider wheelCollider, Transform wheelTransform)
    {
        Vector3 pos;
        Quaternion rot;
        wheelCollider.GetWorldPose(out pos, out rot);
        wheelTransform.rotation = rot;
        wheelTransform.position = pos;
    }
}