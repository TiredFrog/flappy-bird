using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculo : MonoBehaviour
{
    private float velocidade = 0.6f;
 
    void Update()
    {
        this.transform.Translate(Vector3.left * 0.6f * Time.deltaTime);
    }
}
