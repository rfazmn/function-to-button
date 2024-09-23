using System;

    [AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public class ButtonAttribute : Attribute
    {
        public string methodName;
        public ButtonAttribute() { }

        public ButtonAttribute(string name)
        {
            methodName = name;
        }
    }
