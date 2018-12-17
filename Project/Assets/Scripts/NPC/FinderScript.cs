using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinderScript : MonoBehaviour {

    public Transform CalculateNearest(Transform subject, List<Transform> potentialTargets)
    {


        if (potentialTargets.Count < 1)
        {
            Debug.Log("No valid targets");
            return null;
        }

        Transform closestObject = potentialTargets[0];
        for (int i = 0; i < potentialTargets.Count; i++)
        {
            if (Vector3.Distance(subject.position, closestObject.position) > Vector3.Distance(subject.position, potentialTargets[i].position))
            {
                closestObject = potentialTargets[i];
            }
        }


        return closestObject;

        
    }
}
