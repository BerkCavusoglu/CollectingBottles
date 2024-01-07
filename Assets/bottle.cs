using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class bottle : MonoBehaviour
{
    public Transform sise2; 
    public TextMeshProUGUI canYazisi,bitisYazisi;
    public int can ;
    public AudioSource siseDusurme;

    void Update() {
        canYazisi.text = "Health : " + can;

        if(can == 0) {

         bitisYazisi.text = "GAME OVER \n PRESS A KEY TO PLAY AGAIN!";
         Time.timeScale = 0;
         if(Input.anyKeyDown) {

            SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
            Time.timeScale = 1;
         }
        }
    }
    void OnCollisionEnter2D(Collision2D temas) {

        float rastgele = Random.Range(-6.3f,6.3f);

        if (temas.gameObject.tag == "Zemin") {
        sise2.position = new Vector3(rastgele, 6f, 0f);
        can--;
        siseDusurme.Play ();
    }
    }
}
