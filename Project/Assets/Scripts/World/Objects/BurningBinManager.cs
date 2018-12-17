using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BurningBinManager : MonoBehaviour
{

    public static List<Transform> BurningBins = new List<Transform>();
    public static List<Transform> Books = new List<Transform>();




    void Update()
    {
        Debug.Log("BurningBins" + BurningBins.Count);
    }

    




}
