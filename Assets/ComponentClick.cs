using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentClick : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefabMarkTile;

    private void OnMouseOver()
    {
        if (Input.GetMouseButton(0))
        {
            Destroy(gameObject);
        }
        if (Input.GetMouseButton(1))
        {
            Instantiate(prefabMarkTile, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z-1 ), Quaternion.identity);
        }
    }
}
