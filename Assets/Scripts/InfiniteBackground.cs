using UnityEngine;

public class InfiniteBackground : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento
    public float backgroundWidth = 10f; // Ancho del fondo (ajusta según sea necesario)

    private Vector3 startPos; // Posición inicial del fondo


    void Start()
    {
        // Guardamos la posición inicial del fondo
        startPos = transform.position;
        Debug.Log("Posición inicial: " + startPos);
    }

    void Update()
    {
        // Mover el fondo hacia la derecha
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        // Imprimir la posición para ver si cambia
        Debug.Log($"Posición X del fondo: {transform.position.x}");

        // Reposicionar el fondo cuando se salga de la vista
        if (transform.position.x >= startPos.x + backgroundWidth)
        {
            transform.position = startPos;
            Debug.Log("Fondo reposicionado");
        }
    }
}
