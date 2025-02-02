using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterkontrol : MonoBehaviour
{
    public float hiz = 10f;
    public float ziplama = 3f;
    private Animator animator;
    private Rigidbody rb;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float zYonu = Input.GetAxis("Vertical") * hiz;
        float xYonu = Input.GetAxis("Horizontal") * hiz;

        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            rb.AddForce(new Vector3(0, ziplama, 0), ForceMode.Impulse);
        }

        zYonu *= Time.deltaTime;
        xYonu *= Time.deltaTime;

        transform.Translate(xYonu, 0, zYonu);

        if (animator != null)
        {
            animator.SetFloat("OyuncuV", zYonu);
            animator.SetFloat("OyuncuY", rb.velocity.y);
        }
    }
}
