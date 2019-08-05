using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Joystick joystick;

    private void Update()
    {
        this.transform.Translate(new Vector3(joystick.Horizontal, joystick.Vertical, 0f) * moveSpeed * Time.deltaTime,Space.World);
    }
}
