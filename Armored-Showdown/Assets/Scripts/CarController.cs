using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] protected WheelCollider frontLeftWheelCollider, frontRightWheelCollider, rearLeftWheelCollider, rearRightWheelCollider;
    [SerializeField] protected float torque;
    [SerializeField] protected float angle;
    [SerializeField] protected Transform frontLeftWheelTransform;
    [SerializeField] protected Transform frontRightWheelTransform;
    [SerializeField] protected Transform rearLeftWheelTransform;
    [SerializeField] protected Transform rearRightWheelTransform;



    protected void FixedUpdate()
    {
        UpdateSingleWheel(frontLeftWheelCollider, frontLeftWheelTransform);
        UpdateSingleWheel(frontRightWheelCollider, frontRightWheelTransform);
        UpdateSingleWheel(rearRightWheelCollider, rearRightWheelTransform);
        UpdateSingleWheel(rearLeftWheelCollider, rearLeftWheelTransform);
    }
    protected void ApplyTorque(float torque)
    {
        frontRightWheelCollider.motorTorque = torque;
        rearRightWheelCollider.motorTorque = torque;
        frontLeftWheelCollider.motorTorque = torque;
        rearLeftWheelCollider.motorTorque = torque;
    }
    protected void ApplyBrake(float brakeTorque)
    {
        frontRightWheelCollider.brakeTorque = brakeTorque;
        rearRightWheelCollider.brakeTorque = brakeTorque;
        frontLeftWheelCollider.brakeTorque = brakeTorque;
        rearLeftWheelCollider.brakeTorque = brakeTorque;
    }
    protected void ApplySteerAngle(float steerAngle)
    {
        frontLeftWheelCollider.steerAngle = steerAngle;
        frontRightWheelCollider.steerAngle = steerAngle;
    }
    protected void UpdateSingleWheel(WheelCollider wheelCollider, Transform wheelTransform)
    {
        Vector3 pos;
        Quaternion rot;
        wheelCollider.GetWorldPose(out pos, out rot);
        wheelTransform.rotation = rot;
        wheelTransform.position = pos;
    }
}
