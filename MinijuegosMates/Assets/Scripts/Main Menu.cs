using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject      gameMode;

    // ----------- GAME MODES -----------
    public void PlayEasyMode()
    {
        gameMode.GetComponent<GameMode>().setEasyMode = true;
        SceneManager.LoadScene("Minijuego");
    }

    public void PlayMediumMode()
    {
        gameMode.GetComponent<GameMode>().setMediumMode = true;
        SceneManager.LoadScene("Minijuego");
    }

    public void PlayHardMode()
    {
        gameMode.GetComponent<GameMode>().setHardMode = true;
        SceneManager.LoadScene("Minijuego");
    }

    // ----------- QUIT & RETRY -------------

    public void QuitGame()
    {
        Application.Quit();
    }

    public void RetryRunner()
    {
        // Aquí metéis entre las comillas el NOMBRE de la ESCENA de vuestro runner. ¡Recordad meterla en Build Settings antes! <3
        // SceneManager.LoadScene("");
    }
}
