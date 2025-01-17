using UnityEngine;

public class MovimientoGlobo : MonoBehaviour
{
    public float movimiento = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, moveY, 0f);
        transform.Translate(movement * movimiento * Time.deltaTime);

    }
}
