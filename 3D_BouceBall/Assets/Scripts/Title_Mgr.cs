using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Title_Mgr : MonoBehaviour
{
    [Header("Option")]
    public Button Option_Btn;
    public Image Option;
    public Button Option_Close;


    // Start is called before the first frame update
    void Start()
    {
        if(Option_Btn != null)
        {
            Option_Btn.onClick.AddListener(() =>
            {
                Option.gameObject.SetActive(true);
            });
        }

        if (Option_Close != null)
            Option_Close.onClick.AddListener(() =>
            {
                Option.gameObject.SetActive(false);
            });
    }

    // Update is called once per frame
    void Update()
    {
        
    } 
    
}
