using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public NodeSO nodeSO;
    public TextMeshProUGUI objectiveText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (nodeSO.allPlaced == 1)
        {
            this.gameObject.SetActive(false);
            objectiveText.gameObject.GetComponent<Animator>().Play("placeholderTest");
        }
    }
}
