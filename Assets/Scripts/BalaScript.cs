using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaScript : MonoBehaviour
{
    public float speed = 6;

    // É chamado apenas uma vez quando a bala é criada
    void Start()
    {
        // Ajusta a velocidade Y para fazer a bala se mover para cima
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnBecameInvisible()
    {
        // Destroi a bala quando já está fora da tela
        Destroy(gameObject);
    }
}
