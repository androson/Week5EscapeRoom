using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OpenDoor : MonoBehaviour
{
    AudioSource ErrorSound;

    private Animator anim;

    private bool IsAtDoor = false;

    [SerializeField] private TextMeshProUGUI CodeText;
    string codeTextValue = "";
    public string safeCode;
    public GameObject CodePanel;
    public GameObject CluePanel;

    public bool SetClue = false;




    
    void Start()
    {
        anim = GetComponent<Animator>();

        ErrorSound = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        CodeText.text = codeTextValue;

        if(codeTextValue == safeCode)
        {
            anim.SetTrigger("OpenDoor");
            CodePanel.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        if(codeTextValue.Length >= 7)
        {
            ErrorSound.Play();
            codeTextValue = "";
            

        }

        if(Input.GetKey(KeyCode.E) && IsAtDoor == true)
        {
            CodePanel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

        }

        

        if (Input.GetKeyDown(KeyCode.C)) 
        {
    
            CluePanel.SetActive(!CluePanel.activeSelf);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            IsAtDoor = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        IsAtDoor = false;
        CodePanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }
}
