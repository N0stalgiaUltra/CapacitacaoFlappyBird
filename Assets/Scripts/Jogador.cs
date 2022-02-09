using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public float velocidade = 1f;// Variavel responsavel pela velocidade do objeto
    private Rigidbody2D RB2D;// Variavel responsável para a Fisica do Jogador

    public GameObject GameOver;
    // Start is called before the first frame update
    void Start()
    {
        RB2D = GetComponent<Rigidbody2D>();// Faço a chamada ou puxo a Fisica do jogador
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RB2D.velocity = Vector2.up * velocidade;
        }
    }
    void OnCollisionEnter2D(Collision2D colisor)
    {
        GameOver.SetActive(true);// Quando o jagado atinge um box collider carrega a Cena de GameOver
        Time.timeScale=0;// Pausa o Game

    }   
}
