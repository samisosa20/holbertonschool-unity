using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public void LinkedIn()
    {
        Application.OpenURL("https://www.linkedin.com/in/samgutlon/");
    }
    
    public void Github()
    {
        Application.OpenURL("https://github.com/samisosa20");
    }
    
    public void Twitter()
    {
        Application.OpenURL("https://twitter.com/samisosabmx");
    }

    public void Google()
    {
        Application.OpenURL("mailto:1449@holbertonschool.com");
    }
}
