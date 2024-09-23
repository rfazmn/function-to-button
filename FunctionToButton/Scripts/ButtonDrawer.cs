using System.Collections.Generic;
using System.Reflection;

public class ButtonDrawer
{
    List<CustomButton> customButtons = new List<CustomButton>();

    public ButtonDrawer(object target)
    {
        BindingFlags flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
        MethodInfo[] methods = target.GetType().GetMethods(flags);

        foreach (MethodInfo method in methods)
        {
            ButtonAttribute buttonAttribute = method.GetCustomAttribute<ButtonAttribute>();

            if (buttonAttribute == null || method.GetParameters().Length > 0)
                continue;

            customButtons.Add(new CustomButton(buttonAttribute.methodName, method));
        }
    }

    public void DrawButtons(IEnumerable<object> targets)
    {
        foreach (CustomButton button in customButtons)
        {
            button.Draw(targets);
        }
    }
}
