using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour, ICube
{

    public void Hit()
    {
        Debug.Log("OUch");
    }
}

interface ICube
{
    public void Hit();
}