using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private float speed = 7f;
    [SerializeField] private bool isPaddle1;
    private float yBound = 3.75f; //limites de la paleta en pantalla

    void Start()
    {
        
    }

    void Update()
    {
        float movement;

        //detectar que control se usa para cada paleta
        if(isPaddle1)
        {
            movement = Input.GetAxisRaw("Vertical");
        } 
        else 
        {
            movement = Input.GetAxisRaw("Vertical2");
        }

        Vector2 paddlePosition = transform.position;
        paddlePosition.y = Mathf.Clamp(paddlePosition.y + movement * speed * Time.deltaTime, -yBound, yBound); // detecta el movimiento de la paleta segun cual sea y pone limites
        transform.position = paddlePosition;

    }
}
