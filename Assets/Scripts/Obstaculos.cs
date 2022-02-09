using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    public float velocidadeObstaculo;// 

    // void Update executa essa etapa uma vez por frame
    void Update()
    {
        transform.position += Vector3.left * velocidadeObstaculo * Time.deltaTime;// Movimenta o objeto para a esquerda de acordo com o tempo
    }
}
