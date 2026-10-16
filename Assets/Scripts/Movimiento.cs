using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidad = 5f;

    private CambioColor cambioColor;

    // Busca CambioColor en el mismo GameObject.
    void Start()
    {
        cambioColor = GetComponent<CambioColor>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
            cambioColor.CambiarColor(Color.red);
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
            cambioColor.CambiarColor(Color.blue);
        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * velocidad * Time.deltaTime);
            cambioColor.CambiarColor(Color.green);
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * velocidad * Time.deltaTime);
            cambioColor.CambiarColor(Color.yellow);
        }
    }
}