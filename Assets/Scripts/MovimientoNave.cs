using UnityEngine;

public class MovimientoNave : MonoBehaviour
{
    public float fuerza = 1f;
    private Rigidbody2D rb;

    void Start()
    {
        // Obtenemos el Rigidbody2D de la nave.
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // Aplicamos las fuerzas durante la actualización física.

        // Mover hacia arriba con flecha arriba o W.
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector2.up * fuerza, ForceMode2D.Force);
        }

        // Mover hacia abajo con flecha abajo o S.
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector2.down * fuerza, ForceMode2D.Force);
        }

        // Mover hacia la izquierda con flecha izquierda o A.
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left * fuerza, ForceMode2D.Force);
        }

        // Mover hacia la derecha con flecha derecha o D.
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right * fuerza, ForceMode2D.Force);
        }
    }
}