using UnityEngine;

public class movimientoFantasma : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float velocidadMovimiento = 0;

    Rigidbody2D rigidbody;

    void Start()
    {
        rigidbody=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    

    {
        if (Input.GetKey("d"))        {
            rigidbody.linearVelocity = new Vector2(velocidadMovimiento, rigidbody.linearVelocity.y);
        }

        if (Input.GetKey("a"))        {
            rigidbody.linearVelocity = new Vector2(-velocidadMovimiento, rigidbody.linearVelocity.y);
        }

        
        

    }
}
