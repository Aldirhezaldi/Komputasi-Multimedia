using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollows : MonoBehaviour
{
    public Transform ikut;

    void Update(){
        transform.LookAt(ikut);
    }
}
