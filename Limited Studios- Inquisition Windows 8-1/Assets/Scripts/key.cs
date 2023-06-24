using UnityEngine;

public class key : MonoBehaviour
{
    public float speed;
    public bool keys;

    void Update()
    {
        if (keys)
        {
            transform.Rotate(Vector3.left, speed * Time.deltaTime);
        }

        else
        {
            transform.Rotate(Vector3.up, speed * Time.deltaTime);
        }
    }
}
