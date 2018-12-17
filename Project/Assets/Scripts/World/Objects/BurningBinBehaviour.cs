using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurningBinBehaviour : MonoBehaviour {
    
	void Start () {
        BurningBinManager.BurningBins.Add(this.gameObject.transform);
	}


}
