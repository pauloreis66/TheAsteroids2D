using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroideScript : MonoBehaviour
{
    // Contem a velocidade do asteroide
    public int speed = -5;

    // Para se comunicar com o NaveScript
    private PontosScript ptScript; 

    //  Chamada quando o asteroide é criado
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ptScript = GameObject.Find("Pontuacao").GetComponent<PontosScript>();

        // Adicionar speed à velocidade do asteroide
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);

        // Faz o asteroide rodar em si mesmo aleatoriamentre entre -200 e 200 graus
        GetComponent<Rigidbody2D>().angularVelocity = Random.Range(-200, 200);

        // Destroi o asteroide após 3 segundos, que ele não está mais visível na tela
        Destroy(gameObject, 3);
    }

    private void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.tag == "balaTag")
        {
            Destroy(this.gameObject);
            ptScript.pontos++;
        }

    }
}
