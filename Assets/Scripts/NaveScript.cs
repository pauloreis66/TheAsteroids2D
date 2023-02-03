using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class NaveScript : MonoBehaviour
{
    public GameObject bala;
    public int speed = 10;

    private int vidas = 3;
    public TMP_Text vidasGui; // Arrastar vidas da hierarquia para esta variavel

    public AudioClip audioNaveColisao; // Arrastar o audio para esta variavel

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //// Move a nave horizontalmente com setas ou com as teclas A e D
        
        // Eixo X - na horizontal
        float horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(horizontal, 0, 0);// Aplicando as mudanças
        
        // Quando a barra de espaços é pressionada ele atira
        if (Input.GetKeyDown("space"))
        {
            // Cria uma nova bala na posição atual da nave para que siga a nave
            Instantiate(bala, transform.position, Quaternion.identity);
        }

        //vidasGui.fontStyle = FontStyle.Bold;
        //vidasGui.fontSize = 18;
        vidasGui.text = "Vidas: " + vidas;
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        //Debug.Log("Teste");
        if (outro.gameObject.tag == "asteroidTag")
        {
            vidas = vidas - 1; // Cada colisão perde uma vida
            if (vidas == 0)
            {
                // Quando chocar 3 vezes com o inimigo morre
                AudioSource.PlayClipAtPoint(audioNaveColisao, transform.position);
                Destroy(this.gameObject);
                SceneManager.LoadScene("menu");

            }
        }
    }

}
