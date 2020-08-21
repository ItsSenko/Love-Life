using UnityEngine.Animations;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;

    // Speed variables.
    public float speed;
    public float walkSpeed;
    public float runSpeed;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    // Checks if the player is moving or running.
    public bool isMoving;
    public bool isRunning;

    void Update()
    {
        // Makes the Update fuction more clean.

        Move();
        Sprint();
    }

    public void Move()
    {
        float Horizontal = Input.GetAxisRaw("Horizontal");
        float Vertical = Input.GetAxisRaw("Vertical");
        Vector3 Direction = new Vector3(Horizontal, 0f, Vertical).normalized;

        if (Direction.magnitude >= 0.1f)
        {
            isMoving = true;

            float targetAngle = Mathf.Atan2(Direction.x, Direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }
        else
        {
            isMoving = false;
        }
    }

    public void Sprint()
    {
        if (Input.GetButton("run"))
        {
            isRunning = true;
            speed = runSpeed;
        }
        else
        {
            isRunning = false;
            speed = walkSpeed;
        }
    }
}