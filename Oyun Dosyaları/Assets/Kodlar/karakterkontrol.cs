using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterkontrol : MonoBehaviour
{
    public float hiz = 10f;
    public float ziplama = 3f;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float zYonu = Input.GetAxis("Vertical") * hiz;
        float xYonu = Input.GetAxis("Horizontal") * hiz;
        float yYonu = 0f;

        if (Input.GetButtonDown("Jump"))
        {
            yYonu = ziplama;
        }

        zYonu *= Time.deltaTime;
        xYonu *= Time.deltaTime;
        yYonu *= Time.deltaTime;

        transform.Translate(xYonu, yYonu, zYonu);

        if (animator != null)
        {
            animator.SetFloat("OyuncuV", zYonu);
            animator.SetFloat("OyuncuY", yYonu);


        }
    }
}
