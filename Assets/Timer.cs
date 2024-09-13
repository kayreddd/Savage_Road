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
        timeIsRunning = true; // lancer le chronom�tre
    }

    // Update is called once per frame
    void Update()
    {
        if (timeIsRunning)
        {
            if (timeRemaining >= 0)
            {
                timeRemaining += Time.deltaTime; // incr�mente le temps
                DisplayTime(timeRemaining); // affiche le temps restant
            }

            if (GameOverManager.isGameOver) // V�rifier si le jeu est termin�
                timeIsRunning = false; // on arr�te le chrono
        }
    }
    void DisplayTime(float timeToDisplay) //m�thode pour afficher le temps pr�cisemment
    {
        //timeToDisplay += 1;
        // calculer min et sec
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float secondes = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00} : {1:00}", minutes, secondes);
    }
}
    


