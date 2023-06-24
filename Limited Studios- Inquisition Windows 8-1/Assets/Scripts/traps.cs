using UnityEngine;

public class traps : MonoBehaviour
{
    public Transform target;
    public Transform stabbyThing;
    public float distance;

    public bool XorZ;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject == target)
        {
            Stab(XorZ);
        }
        else
        {
            stabbyThing.transform.Translate(0, 0, 0);
        }
    }

    void Stab(bool axis)
    {
        Debug.Log("STAB!");
        if (axis == true) //X axis
        {
            stabbyThing.transform.Translate(distance, 0, 0);
        }
        
        else
        {
            stabbyThing.transform.Translate(0, distance, 0);
        }
    }
}