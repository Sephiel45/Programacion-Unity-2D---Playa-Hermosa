﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformaHorizontalActivable : MonoBehaviour
{
    public float velocidad;
    public float desplazamiento;

    float positionX;
    float positionY;

    bool moveRight = true;
    bool moveUp = true;
    public bool activada = false;

    void Start()
    {
        positionX = transform.position.x;
        positionY = transform.position.y;
    }

    void FixedUpdate()
    {
        if (transform.position.x > positionX + desplazamiento)
        {
            moveRight = false;
        }
        if (transform.position.x < positionX)
        {
            moveRight = true;
        }

        if (transform.position.y > positionY + desplazamiento)
        {
            moveUp = false;
        }
        if (transform.position.y < positionY)
        {
            moveUp = true;
        }


        if (moveRight && activada)
        {
            transform.position = new Vector2(transform.position.x + velocidad * Time.deltaTime, transform.position.y);
        }
        else if (!moveRight && activada)
        {
            transform.position = new Vector2(transform.position.x - velocidad * Time.deltaTime, transform.position.y);
        }

    }
}
