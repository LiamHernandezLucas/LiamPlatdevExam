using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryWorkerSystem : MonoBehaviour {

    [SerializeField]
    FinderScript finderScript;

  Transform _target;

    void Update()
    {
        SeekBook();
        SeekBin();

    }
	
    void SeekBook()
    {
        _target = finderScript.CalculateNearest(this.transform, BurningBinManager.Books);

        if (_target != null)
        Debug.Log("Nearest Book is at" + _target.position);
    }

    void SeekBin()
    {
        _target = finderScript.CalculateNearest(this.transform, BurningBinManager.BurningBins);
        if (_target != null)

            Debug.Log("Nearest Bin is at" + _target.position);
    }

}
