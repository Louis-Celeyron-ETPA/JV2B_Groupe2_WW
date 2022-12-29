using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Second_mini_game_movement_and_attack : MonoBehaviour
{
    public GameObject playablecharacter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playablecharacter.transform.eulerAngles = new Vector3(0f,0f,-90f);
            playablecharacter.transform.position = new Vector3(-1, 0, 0);
            Debug.DrawRay(playablecharacter.transform.position, -playablecharacter.transform.up * 1f);
            if (Physics.Raycast(playablecharacter.transform.position, -playablecharacter.transform.up, out var other, 1f) & Input.GetKey(KeyCode.LeftArrow))
            {
                Debug.Log("BBBBBBBBBBBBBBBBBBBBBBBBBBBBB");

                Destroy(other.transform.gameObject);
            }
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            playablecharacter.transform.eulerAngles = new Vector3(0f, 0f, 90f);
            playablecharacter.transform.position = new Vector3(1, 0, 0);
            Debug.DrawRay(playablecharacter.transform.position, -playablecharacter.transform.up * 1f);
            if (Physics.Raycast(playablecharacter.transform.position, -playablecharacter.transform.up, out var other, 1f) & Input.GetKey(KeyCode.RightArrow))
            {
                Debug.Log("BBBBBBBBBBBBBBBBBBBBBBBBBBBBB");

                Destroy(other.transform.gameObject);
            }
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            playablecharacter.transform.eulerAngles = new Vector3(0f, 0f, 180f);
            playablecharacter.transform.position = new Vector3(0, 1, 0);
            Debug.DrawRay(playablecharacter.transform.position, -playablecharacter.transform.up * 1f);
            Debug.DrawRay(playablecharacter.transform.position, -playablecharacter.transform.up * 1f);
            if (Physics.Raycast(playablecharacter.transform.position, -playablecharacter.transform.up, out var other, 1f) & Input.GetKey(KeyCode.UpArrow))
            {
                Debug.Log("BBBBBBBBBBBBBBBBBBBBBBBBBBBBB");

                Destroy(other.transform.gameObject);
            }
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            playablecharacter.transform.eulerAngles = new Vector3(0f, 0f, -180f);
            playablecharacter.transform.position = new Vector3(0, -1, 0);
            Debug.DrawRay(playablecharacter.transform.position, playablecharacter.transform.up * 1f);
            if (Physics.Raycast(playablecharacter.transform.position, playablecharacter.transform.up, out var other, 1f) & Input.GetKey(KeyCode.DownArrow))
            {
                Debug.Log("BBBBBBBBBBBBBBBBBBBBBBBBBBBBB");

                Destroy(other.transform.gameObject);
            }
        }
    }

}