using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI.Table;

public class NodeSnap : MonoBehaviour
{
    public NodeSO NodeSO;
    private bool placed = false;
    private Vector3 locked;
    private void Start()
    {
        NodeSO.allPlaced = 0;
    }
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("port") && placed == false && this.GetComponent<Renderer>().material.color == other.gameObject.GetComponent<Renderer>().material.color)
        {
            Debug.Log("hit");
            locked = other.transform.position;
            this.transform.position = locked;
            this.transform.rotation = new Quaternion(0, 0, 0, 0);
            //this.GetComponent<Renderer>().material.color = new Color(0, 0, 55);
            this.tag = "placed";
            NodeSO.allPlaced++;
            placed = true;
        }
    }
    private void Update()
    {
        if (placed == true)
        {
            transform.position = locked;
            transform.rotation = new Quaternion(0,0,0,0);
            //this.GetComponent<Renderer>().material.color = new Color(0, 0, 55);
        }
    }
}
