using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Rigidbody rb;
    private void Start()
    {
        rb.useGravity = false;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            rb.useGravity = false;
            Debug.Log("Collided with Player");

        }
    }
}
