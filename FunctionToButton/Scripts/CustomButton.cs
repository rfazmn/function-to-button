using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class CustomButton
{
    string methodName;
    MethodInfo methodInfo;

    public CustomButton(string name, MethodInfo info)
    {
        methodName = name;
        methodInfo = info;
    }

    public void Draw(IEnumerable<object> targets)
    {
        string buttonName = !string.IsNullOrEmpty(methodName) ? methodName : methodInfo.Name;
        if (GUILayout.Button(buttonName))
        {
            foreach (object obj in targets)
            {
                methodInfo.Invoke(obj, null);
            }
        }
    }
}
