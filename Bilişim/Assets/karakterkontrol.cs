using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterkontrol : MonoBehaviour
{
    public float hiz = 10f;
    public float ziplama = 3f;
    private void Start()
    {
    }

      void Update()
        {
            float zYonu = Input.GetAxis("Vertical") * hiz;
            float xYonu = Input.GetAxis("Horizontal") * hiz;
            float yYonu = Input.GetAxis("Jump") * ziplama;
            zYonu *= Time.deltaTime;
            xYonu *= Time.deltaTime;
            yYonu *= Time.deltaTime;


        transform.Translate(xYonu,yYonu, zYonu);
        }
    }
