using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionController : MonoBehaviour
{
    public Text gameOverText; //texte qui s'affiche

    private void OnTriggerEnter2D(Collider2D collision) //m�thode collision
    {
        if(collision.CompareTag("Obstacle")) // on v�rifie si il ya collision
        {
            GameOverManager.isGameOver = true; // le jeu va se terminer
            gameObject.SetActive(false); //d�sactive les mouv du joueur
            
            //GameOver();
        }
    }


    public void GameOver(){
        
        Debug.Log("Boom");
        // Affiche le texte "Game Over"
        gameOverText?.gameObject.SetActive(true); //afficher le texte lorsque le joueur peut pas bouger 
    }

    void MissionCompleted(){
        
    }
}
