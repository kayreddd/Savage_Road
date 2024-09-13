using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoScaleEndGame : MonoBehaviour
{
    public GameObject gameOver;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(gameOver, transform.position, Quaternion.identity);
        transform.DOScale(6, 3);

        // if(test.CompareTag("Finish"))
        // {
        //     // Instantiate(gameOver);
        //     transform.DOScale(6, 3);
        // }
    }
    
    // {
    //     gameObject.SetActive(false);

    //     if(collision.CompareTag("Finish")) {
    //         gameObject.SetActive(true);
    //         transform.DOScale(6, 3);
    //     }
    // }

    // private int numberOfAppearances = 0;

    // void Update()
    // {
    //     if (Input.GetMouseButtonDown(0))
    //     {
    //         // Vérifie si le nombre d'apparitions est inférieur à 3
    //         if (numberOfAppearances < 3)
    //         {
    //             // Active l'objet
    //             gameObject.SetActive(true);
    //             numberOfAppearances++; // Incrémente le compteur
    //         }
    //     }

    //     if (Input.GetMouseButtonDown(1))
    //     {
    //         // Désactive l'objet
    //         gameObject.SetActive(false);
    //     }
    // }


}
