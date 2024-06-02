using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newObject : MonoBehaviour
{
    public GameObject obj;
    public Transform objPos;
    public void Click(){
        Instantiate(obj, objPos);
    }
}
