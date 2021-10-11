using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineClick : MonoBehaviour
{
    private GameObject[] listCoveredTiles;
    // Start is called before the first frame update
    void Start()
    {
        listCoveredTiles = GameObject.FindGameObjectsWithTag("Cover");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseOver()
    {
        if (Input.GetMouseButton(0))
        {
            for (int i = 0; i < listCoveredTiles.Length; i++)
            {
                Destroy(listCoveredTiles[i]);
            }
        }

    }
}
