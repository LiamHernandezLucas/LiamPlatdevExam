using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript : MonoBehaviour {
    [SerializeField]
    string _key;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<ItemScript>() != null)
            if(other.gameObject.GetComponent<ItemScript>().ItemKey == _key)
            {
                Destroy(other.gameObject);

            }
    }
}
