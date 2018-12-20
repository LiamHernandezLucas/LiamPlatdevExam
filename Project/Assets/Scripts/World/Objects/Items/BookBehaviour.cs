

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookBehaviour : MonoBehaviour {

    void Start()
    {
        BurningBinManager.Books.Add(this.gameObject.transform);
    }

    private void OnDestroy()
    {
        BurningBinManager.Books.Remove(this.gameObject.transform);
    }
}
