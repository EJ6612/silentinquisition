using UnityEngine;
using UnityEngine.SceneManagement;

public class endinMenus : MonoBehaviour
{

    public int change;

    public void changeToScene(int changeToScene)
    {
        SceneManager.LoadScene(changeToScene);        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape) || Input.GetKey(KeyCode.Space))
        {
            changeToScene(change);
        }       
    }
}