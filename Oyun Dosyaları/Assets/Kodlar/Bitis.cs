using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bitis : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Oyun Bitti");
            Time.timeScale = 0;
        }
    }

}
