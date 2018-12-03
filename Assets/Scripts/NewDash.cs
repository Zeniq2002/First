using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDash : MonoBehaviour
{
    public DashState dashState;
    public float dashTimer;
    public float maxDash = 20f;
    public Rigidbody2D myRigidbody;

    public Vector2 savedVelocity;

    void Update()
    {
        switch (dashState)
        {
            case DashState.Ready:
                var isDashKeyDown = Input.GetKeyDown(KeyCode.M);
                if (isDashKeyDown)
                {
                    savedVelocity = GetComponent<Rigidbody2D>().velocity;
                    myRigidbody.velocity = new Vector2(myRigidbody.velocity.x * 3f, myRigidbody.velocity.y);
                    dashState = DashState.Dashing;
                }
                break;
            case DashState.Dashing:
                dashTimer += Time.deltaTime * 3;
                if (dashTimer >= maxDash)
                {
                    dashTimer = maxDash;
                    myRigidbody.velocity = savedVelocity;
                    dashState = DashState.Cooldown;
                }
                break;
            case DashState.Cooldown:
                dashTimer -= Time.deltaTime;
                if (dashTimer <= 0)
                {
                    dashTimer = 0;
                    dashState = DashState.Ready;
                }
                break;
        }
    }
}

public enum DashState
{
    Ready,
    Dashing,
    Cooldown
}
