using UnityEngine;

public class ColorPropulsor : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // Obtenemos el SpriteRenderer del propulsor.
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Flecha arriba o W: rojo.
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            spriteRenderer.color = Color.red;
        }

        // Flecha abajo o S: azul.
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            spriteRenderer.color = Color.blue;
        }

        // Flecha izquierda o A: verde.
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            spriteRenderer.color = Color.green;
        }

        // Flecha derecha o D: amarillo.
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            spriteRenderer.color = Color.yellow;
        }
    }
}