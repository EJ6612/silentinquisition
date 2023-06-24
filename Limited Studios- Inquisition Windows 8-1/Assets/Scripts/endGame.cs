using UnityEngine;
using UnityEngine.SceneManagement;

public class endGame : MonoBehaviour
{
    public Transform target;
    public int Scene;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject == target)
        {
            ChangeToScene(Scene);
        }
    }

    void ChangeToScene(int changeToScene)
    {
        SceneManager.LoadScene(changeToScene);
    }
}
