using UnityEngine;

public class MovimientoTransform : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
        // Leemos las flechas izquierda/derecha o A/D.
        float movimiento = Input.GetAxisRaw("Horizontal");

        // Movemos el objeto horizontalmente.
        transform.Translate(
            Vector3.right * movimiento * velocidad * Time.deltaTime
        );
    }
}