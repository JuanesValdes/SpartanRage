using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public Animator Spartan;
    public Transform Player;
    public bool isGrounded = false;
    public float moveSpeed = 5f;
    void Start()
    {
        Spartan = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
        
        

    }
    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
            Spartan.SetBool(name: "Player_Jump", value: true);
            Spartan.SetBool(name: "Player_Idle", value: false);
            Spartan.SetBool(name: "Player_Run", value: false);

        }

    }

}
