using System.Numerics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class animation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame

    Animator playerAnim;

    private void Awake()
    {
        playerAnim = GetComponent<Animator>();
    }
    void Update()
    {
        if(Vector)
        if (Input.GetKeyDown(KeyCode.Q))
        {
            print("Stopwalk");
            playerAnim.SetBool("Wallk test", false);
                
        }
        if (Input.GetKeyDown(KeyCode.W))
            {
                print("Wallk test");
                playerAnim.SetBool("Wallk test", true);
            }
    }
}

