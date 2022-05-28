using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private GameObject lvl;
    public float speed = 5f;
    private float direction = 0f;
    private Rigidbody2D _rb;

    private void Awake() => _rb = GetComponent<Rigidbody2D>();

    private void Update()
    {
        direction = Input.GetAxis("Horizontal");

        //lvl.transform.eulerAngles == new Vector3(0,0,-180) || lvl.transform.eulerAngles == new Vector3(0, 0, 180) || 

        if (lvl.transform.eulerAngles == new Vector3(0, 0, -90))
        {
            speed = -5;
        }
        else
        {
            speed = 5;
        }

    }

    private void FixedUpdate() => _rb.velocity = new Vector2(direction * speed, _rb.velocity.y);
}