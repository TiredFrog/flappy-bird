using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geradorObs : MonoBehaviour
{

    [SerializeField]
    private float tempoParaGerar;

    private float cronometro;

    [SerializeField]

    private GameObject modeloObstaculo;

    private void Awake()
    {
        this.cronometro = this.tempoParaGerar;
    }

    void Update()
    {
        this.cronometro -= Time.deltaTime;
        if (this.cronometro < 0)
        {
            GameObject.Instantiate(this.modeloObstaculo, this.transform.position, Quaternion.identity);
            this.cronometro = this.tempoParaGerar;
        }
    }
}
