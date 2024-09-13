using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public static bool isGameOver; // indique si le jeu est termin�
    public GameObject gameOverScreen; // popup � l'�cran

    private void Awake() // d�marrage du jeu
    {
        isGameOver = false;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver)
        {
            gameOverScreen.SetActive(true); // activation du popup
        }
        
    }

    public void ReplayGame()
    {
        // nouvelle sc�ne pour relancer le jeu
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
