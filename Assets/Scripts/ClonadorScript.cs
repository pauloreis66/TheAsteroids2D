using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClonadorScript : MonoBehaviour
{
    // Armazenará o prefab Asteroide
    public GameObject asteroide;

    // Variável para conhecer quão rápido nós devemos criar novos Asteroides
    public float spawnTime = 2;

    // Start is called before the first frame update
    void Start()
    {
        // Chamar a função 'addEnemy' a cada 'spawnTime' segundos
        InvokeRepeating("addEnemy", spawnTime, spawnTime);

    }

    // Nova funçao para clonar/spawn um Asteroide
    void addEnemy()
    {
        // Variável para armazenar a posição X do objeto spawn. Veja abaixo
        var x1 = transform.position.x - GetComponent<Renderer>().bounds.size.x / 2;
        var x2 = transform.position.x + GetComponent<Renderer>().bounds.size.x / 2;
        // Aleatoriamente escolhe um ponto dentro do objeto spawn
        var spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);
        // Criar um Asteroide na posição 'spawnPoint'
        Instantiate(asteroide, spawnPoint, Quaternion.identity);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
