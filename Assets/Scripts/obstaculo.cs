using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.6f;

    [SerializeField]
    private float variacaoY;

    [SerializeField]
    private Vector3 posicaoPassaro;

    private bool pontuei;

    private UIcontroler controladorUI;

    private void Start()
    {
        this.posicaoPassaro = GameObject.FindObjectOfType<passaro>().transform.position;
        this.controladorUI = GameObject.FindObjectOfType<UIcontroler>();
    }

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoY,variacaoY));
    }

    void Update()
    {
        this.transform.Translate(Vector3.left * 0.6f * Time.deltaTime);
        if (!this.pontuei && this.transform.position.x < posicaoPassaro.x)
        {
            this.controladorUI.adcPontos();
            this.pontuei = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.Destruir();
    }

    private void Destruir()
    {
        Destroy(this.gameObject);
    }
}
