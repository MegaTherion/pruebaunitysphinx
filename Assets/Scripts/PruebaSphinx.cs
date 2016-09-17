using UnityEngine;
using System.Collections;

public class PruebaSphinx : MonoBehaviour
{
    string str;
    // Use this for initialization
    void Start()
    {
        UnitySphinx.Init();
        UnitySphinx.Run();
    }

    // Update is called once per frame
    void Update()
    {

        str = UnitySphinx.DequeueString();
        if (UnitySphinx.GetSearchModel() == "kws")
        {
            print("listening for keyword");
            if (str != "")
            {
                UnitySphinx.SetSearchModel(UnitySphinx.SearchModel.jsgf);
                //guitext.text = "order up";
                print(str);
            }
        }
        else if (UnitySphinx.GetSearchModel() == "jsgf")
        {
            if (str!="")
            {
                Vector3 v;
                if (str == "up")
                    v = new Vector3(0, 0.5f, 0);
                else if (str == "down")
                    v = new Vector3(0, -0.5f, 0);
                else if (str == "right")
                    v = new Vector3(0.5f, 0, 0);
                else v = new Vector3(-0.5f, 0, 0);

                transform.position += v;
                print(str);
            }
                
                
        }
    }
}
