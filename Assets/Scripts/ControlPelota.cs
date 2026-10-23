using UnityEngine;

public class ControlPelota : MonoBehaviour
{
    public float velocidadHorizontal = 1f;
    public float fuerzaImpulso = 2f;
    private Rigidbody2D rb;

    void Awake()
    {
        // Obtenemos el Rigidbody2D de la pelota.
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        // La pelota comienza moviéndose hacia la derecha.
        rb.linearVelocity = new Vector2(
            velocidadHorizontal,
            0f
        );
    }

    void Update()
    {
        // Al presionar espacio, damos un impulso hacia arriba.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(
                Vector2.up * fuerzaImpulso,
                ForceMode2D.Impulse
            );
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Mostramos un mensaje cuando toca el suelo.
        if (collision.gameObject.name == "Suelo")
        {
            Debug.Log("La pelota cayó al suelo.");
        }
    }
}