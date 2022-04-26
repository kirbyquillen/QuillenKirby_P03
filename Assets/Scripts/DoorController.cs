using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    Animator _doorAnim;

    public void Open()
    {
        _doorAnim.SetBool("isOpening", true);
    }

    public void Close()
    {
        _doorAnim.SetBool("isOpening", false);
    }

    // Start is called before the first frame update
    void Start()
    {
        _doorAnim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
