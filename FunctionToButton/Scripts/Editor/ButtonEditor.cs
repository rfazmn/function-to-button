using UnityEditor;

#if UNITY_EDITOR

    [CustomEditor(typeof(object), true)]
    [CanEditMultipleObjects]
    public class ButtonEditor : Editor
    {
        ButtonDrawer buttonDrawer;

        private void OnEnable()
        {
            buttonDrawer = new ButtonDrawer(target);
        }

        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            buttonDrawer.DrawButtons(targets);
        }
    }
#endif
