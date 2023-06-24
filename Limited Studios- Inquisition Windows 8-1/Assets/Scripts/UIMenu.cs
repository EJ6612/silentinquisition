using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIMenu : MonoBehaviour
{
    public Transform Canvas;

    public Transform instructCanvas;
    public Button instructButton;
    public Button instructButton2;

    public Transform creditsCanvas;
    public Button creditsButton;
    public Button creditsButton2;

    public void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void ChangeToScene(int changeToScene)
    {
        SceneManager.LoadScene(changeToScene);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Instructions()
    {
        if (instructButton.gameObject.activeInHierarchy == true)
        {
            instructCanvas.gameObject.SetActive(true);
            Canvas.gameObject.SetActive(false);
        }

        else
        {
            instructCanvas.gameObject.SetActive(false);
            Canvas.gameObject.SetActive(true);
        }
    }

    public void InstructionsExit()
    {
        if (instructButton2.gameObject.activeInHierarchy == true)
        {
            instructCanvas.gameObject.SetActive(false);
            Canvas.gameObject.SetActive(true);
        }

        else
        {
            instructCanvas.gameObject.SetActive(true);
            Canvas.gameObject.SetActive(false);
        }
    }

    public void Credits()
    {
        if (creditsButton.gameObject.activeInHierarchy == true)
        {
            creditsCanvas.gameObject.SetActive(true);
            Canvas.gameObject.SetActive(false);
        }

        else
        {
            creditsCanvas.gameObject.SetActive(false);
            Canvas.gameObject.SetActive(true);
        }
    }

    public void CreditsExit()
    {
        if (creditsButton2.gameObject.activeInHierarchy == true)
        {
            creditsCanvas.gameObject.SetActive(false);
            Canvas.gameObject.SetActive(true);
        }

        else
        {
            creditsCanvas.gameObject.SetActive(true);
            Canvas.gameObject.SetActive(false);
        }
    }
}
