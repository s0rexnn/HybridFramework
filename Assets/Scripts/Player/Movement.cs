using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [Header("Movement")]

    public float topSpeed = 22.5f;
    public float acceleration = 0f;
    public float deceleration = 0f;

    [Header("Gravity")]

    public float jumpForce = 22.5f; 
    public bool isGrounded = true;




}
