using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class passaro : MonoBehaviour
{
    Rigidbody2D fisica;
    private float velocidade = 3f;

    private void Awake() 
   

    {
        this.fisica = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.Impulsionar();
        }
    }

    void Impulsionar()
    {
        this.fisica.AddForce(Vector2.up * 3, ForceMode2D.Impulse);
    }
}
