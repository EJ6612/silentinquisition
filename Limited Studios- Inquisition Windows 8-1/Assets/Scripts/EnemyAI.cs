using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyAI : MonoBehaviour
{
    //public Transform target;
    public Transform target_collider;
    //public int scene;

    public NavMeshAgent agent;
    public float updateDelay;
    public int rotateSpeed;

    //bool isPlayerAlive = true;

    //void ChangeToScene(int changeToScene)
    //{
    //    SceneManager.LoadScene(changeToScene);
    //}

    void Reset()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        InvokeRepeating("FollowTarget", 0f, updateDelay);
    }

    //void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Player" || collision.gameObject == target_collider)
    //    {
    //       // Destroy(collision.gameObject);
    //        isPlayerAlive = false;
    //    }
    //    else
    //    {
    //        isPlayerAlive = true;
    //    }
    //}

    // Update is called once per frame
    void FollowTarget()
    {
        agent.SetDestination(target_collider.position);
    }

    //void Update()
    //{
    //    if (isPlayerAlive == true)
    //    {            
    //        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target_collider.position - transform.position), rotateSpeed * Time.deltaTime);
    //    }       
    //}
}