using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Title_Mgr : MonoBehaviour
{
    public Image m_Fade;
    float m_fadeIn = 1.0f;
    float m_fadeOut = 0.0f;
    float m_Intime = 0;
    float m_Outtime = 0;

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
        if (Input.GetMouseButtonDown(0))
        {
            m_Intime += Time.deltaTime;
            if (m_fadeIn > 0.0f && m_Intime > 0.1f)
            {
                m_fadeIn -= 0.1f;
                m_Fade.color = new Color(0, 0, 0, m_fadeIn);
                m_Intime = 0;
            }
            else if(m_fadeIn < 0.0f)
            {
                m_Intime = 0;
                m_fadeIn = 0;
            }
            if(m_fadeIn < 0)
            {
                m_Fade.gameObject.SetActive(false);
            }
            SceneManager.LoadScene("Stage");
        }
    } 
    
}
