using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public int addPoints;
    public gameEngine ge;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("BallPoint")){
            ge.addPoints(addPoints);
            Destroy(other.gameObject);
            Debug.Log("point - " + addPoints);
        }
    }
}
