using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car1 : MonoBehaviour
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
        if (Input.GetKey(KeyCode.W))
        {
            frontRightWheelCollider.motorTorque = torque;
            rearRightWheelCollider.motorTorque = torque;
            frontLeftWheelCollider.motorTorque = torque;
            rearLeftWheelCollider.motorTorque = torque;

            frontRightWheelCollider.brakeTorque = 0;
            rearRightWheelCollider.brakeTorque = 0;
            frontLeftWheelCollider.brakeTorque = 0;
            rearLeftWheelCollider.brakeTorque = 0;

        }
        else
        {
            frontRightWheelCollider.motorTorque = 0;
            rearRightWheelCollider.motorTorque = 0;
            frontLeftWheelCollider.motorTorque = 0;
            rearLeftWheelCollider.motorTorque = 0;
        }

        if (Input.GetKey(KeyCode.S))
        {
            frontRightWheelCollider.motorTorque = 0;
            rearRightWheelCollider.motorTorque = 0;
            frontLeftWheelCollider.motorTorque = 0;
            rearLeftWheelCollider.motorTorque = 0;

            frontRightWheelCollider.brakeTorque = torque;
            rearRightWheelCollider.brakeTorque = torque;
            frontLeftWheelCollider.brakeTorque = torque;
            rearLeftWheelCollider.brakeTorque = torque;
        }
        else
        {
            frontRightWheelCollider.brakeTorque = 0;
            rearRightWheelCollider.brakeTorque = 0;
            frontLeftWheelCollider.brakeTorque = 0;
            rearLeftWheelCollider.brakeTorque = 0;
        }
        if (Input.GetKey(KeyCode.D))
        {
            frontLeftWheelCollider.steerAngle = angle;
            frontRightWheelCollider.steerAngle = angle;
        }
        else
        {
            if (Input.GetKey(KeyCode.A))
            {
                frontLeftWheelCollider.steerAngle = -angle;
                frontRightWheelCollider.steerAngle = -angle;
            }
            else
            {
                frontLeftWheelCollider.steerAngle = 0;
                frontRightWheelCollider.steerAngle = 0;
            }
        }
        UpdateSingleWheel(frontLeftWheelCollider, frontLeftWheelTransform);
        UpdateSingleWheel(frontRightWheelCollider, frontRightWheelTransform);
        UpdateSingleWheel(rearRightWheelCollider, rearRightWheelTransform);
        UpdateSingleWheel(rearLeftWheelCollider, rearLeftWheelTransform);
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
