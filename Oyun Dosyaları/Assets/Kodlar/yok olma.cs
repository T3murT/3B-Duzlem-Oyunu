using UnityEngine;

public class yokolma : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            Debug.Log("Oyuncu balona �arpt� ve balon yok oldu.");
            Destroy(gameObject);
        }
    }
}
