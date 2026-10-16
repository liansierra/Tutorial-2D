using UnityEngine;

public class CambioColor : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    // Obtiene el Sprite Renderer del objeto.
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Cambia el color usando el valor enviado por Movimiento.
    public void CambiarColor(Color nuevoColor)
    {
        spriteRenderer.color = nuevoColor;
    }
}