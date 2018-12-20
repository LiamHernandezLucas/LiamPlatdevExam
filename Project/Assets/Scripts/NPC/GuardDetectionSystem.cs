using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardDetectionSystem : MonoBehaviour {

    [SerializeField]
    float _detectionDistance;

    private void FixedUpdate()
    {
        CalculateDistance();
    }


    void CalculateDistance()
    {
        if (Vector3.Distance(this.transform.position, GameManager.PlayerCharacter.transform.position) <= _detectionDistance)
        {
            Debug.Log("Detected");
            Debug.DrawLine(this.transform.position, GameManager.PlayerCharacter.transform.position, Color.red);
        }
    }
}
