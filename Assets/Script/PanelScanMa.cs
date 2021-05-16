using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelScanMa : MonoBehaviour
{
    public RawImage rawimge;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Rawimage());
    }

    // Update is called once per frame
    public IEnumerator Rawimage()
    {
        yield return new WaitForSeconds(7f);
        rawimge.gameObject.SetActive(false);
    }
}
