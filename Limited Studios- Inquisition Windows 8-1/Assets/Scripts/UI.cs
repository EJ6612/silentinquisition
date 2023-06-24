using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

    public class UI : MonoBehaviour
    {
        public bool reset = false;

        public Transform Canvas;

        public Transform PauseCanvas;
        public Button pauseButton;
        public Button pauseButton2;

        public Transform instructCanvas;
        public Button instructButton;
        public Button instructButton2;

        public Transform exitCanvas;
        public Button exitButton;
        public Button exitButton2;

        //PlayerMovement pm;

        public void ChangeToScene(int changeToScene)
        {
            SceneManager.LoadScene(changeToScene);            
        }

        public void Quit()
        {
            Application.Quit();
        }

        private void Start()
        {
            Canvas.gameObject.SetActive(true);
        }

        //DO NOT EDIT!!!
        public void Update()
        {
            if (Canvas.gameObject.activeInHierarchy == true) //NOT PAUSED
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;

                Time.timeScale = 1;
            }

            else //PAUSED
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;

                Time.timeScale = 0;
            }

            if ((Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Space)) && (Canvas.gameObject.activeInHierarchy == true || PauseCanvas.gameObject.activeInHierarchy == true))
            {
                if (pauseButton.gameObject.activeInHierarchy == false)
                {
                    PauseMenu();
                }

                else if (pauseButton2.gameObject.activeInHierarchy == false)
                {
                    PauseMenuExit();
                }

                else
                {
                    PauseCanvas.gameObject.SetActive(false);
                }

            }

        }

        //DO NOT EDIT!!!!!!!
        public void PauseMenu()
        {
            if (pauseButton.gameObject.activeInHierarchy == true)
            {
                PauseCanvas.gameObject.SetActive(true);
                Canvas.gameObject.SetActive(false);
                Time.timeScale = 0;
            }

            else
            {
                PauseCanvas.gameObject.SetActive(false);
                Canvas.gameObject.SetActive(true);
                Time.timeScale = 1;
            }
        }

        public void PauseMenuExit()
        {
            if (pauseButton2.gameObject.activeInHierarchy == true)
            {
                PauseCanvas.gameObject.SetActive(false);
                Canvas.gameObject.SetActive(true);
                Time.timeScale = 1;
            }

            else
            {
                PauseCanvas.gameObject.SetActive(true);
                Canvas.gameObject.SetActive(false);
                Time.timeScale = 0;
            }
        }

        public void Instructions()
        {
            if (instructButton.gameObject.activeInHierarchy == true)
            {
                instructCanvas.gameObject.SetActive(true);
                PauseCanvas.gameObject.SetActive(false);
                Time.timeScale = 0;
            }

            else
            {
                instructCanvas.gameObject.SetActive(false);
                PauseCanvas.gameObject.SetActive(true);
                Time.timeScale = 0;
            }
        }

        public void InstructionsExit()
        {
            if (instructButton2.gameObject.activeInHierarchy == true)
            {
                instructCanvas.gameObject.SetActive(false);
                PauseCanvas.gameObject.SetActive(true);
                Time.timeScale = 0;
            }

            else
            {
                instructCanvas.gameObject.SetActive(true);
                PauseCanvas.gameObject.SetActive(false);
                Time.timeScale = 0;
            }
        }

        public void ExitGame()
        {
            if (exitButton.gameObject.activeInHierarchy == true)
            {
                exitCanvas.gameObject.SetActive(true);
                PauseCanvas.gameObject.SetActive(false);
                Time.timeScale = 0;
            }

            else
            {
                exitCanvas.gameObject.SetActive(false);
                PauseCanvas.gameObject.SetActive(true);
                Time.timeScale = 0;
            }
        }

        public void ExitGameNo()
        {
            if (exitButton2.gameObject.activeInHierarchy == true)
            {
                exitCanvas.gameObject.SetActive(false);
                PauseCanvas.gameObject.SetActive(true);
                Time.timeScale = 0;
            }

            else
            {
                exitCanvas.gameObject.SetActive(true);
                PauseCanvas.gameObject.SetActive(false);
                Time.timeScale = 0;
            }
        }
    }

