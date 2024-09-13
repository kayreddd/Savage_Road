using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 0; // Temps initial restant
    public bool timeIsRunning = true;
    public TMP_Text timeText; // afficher temps en texte




    // Start is called before the first frame update
    void Start()
    {
        timeIsRunning = true; // lancer le chronomètre
    }

    // Update is called once per frame
    void Update()
    {
        if (timeIsRunning)
        {
            if (timeRemaining >= 0)
            {
                timeRemaining += Time.deltaTime; // incrémente le temps
                DisplayTime(timeRemaining); // affiche le temps restant
            }

            if (GameOverManager.isGameOver) // Vérifier si le jeu est terminé
                timeIsRunning = false; // on arrête le chrono
        }
    }
    void DisplayTime(float timeToDisplay) //méthode pour afficher le temps précisemment
    {
        //timeToDisplay += 1;
        // calculer min et sec
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float secondes = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00} : {1:00}", minutes, secondes);
    }
}
    


