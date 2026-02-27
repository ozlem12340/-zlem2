using UnityEngine;

public class KardanAdam : MonoBehaviour
{
    public float ziplamaGucu = 10f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = Vector2.up * ziplamaGucu;
        }
    }
}
