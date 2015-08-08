namespace LuaQ {

	using UnityEngine;
	using UnityEditor;

	[CustomPropertyDrawer(typeof(GenericValue))]
	public class GenericValuePropertyDrawer : PropertyDrawer {
		public override void OnGUI (Rect position, SerializedProperty property, GUIContent label) {
			EditorGUI.BeginProperty(position, label, property);
			var typeProperty = property.FindPropertyRelative ("valueType");
			typeProperty.enumValueIndex = (int)(ValueType)EditorGUI.EnumPopup (new Rect(position.x, position.y, 100, position.height), (ValueType)typeProperty.enumValueIndex);

			if (GUI.changed)
				property.serializedObject.ApplyModifiedProperties ();

			var rc = new Rect (position.x + 100, position.y, position.width - 100, position.height);
			switch ((ValueType) typeProperty.enumValueIndex) {
			case ValueType.Int:
				EditorGUI.PropertyField (rc, property.FindPropertyRelative("intValue"));
				break;
			case ValueType.Float:
				EditorGUI.PropertyField (rc, property.FindPropertyRelative("floatValue"));
				break;
			case ValueType.Bool:
				EditorGUI.PropertyField (rc, property.FindPropertyRelative("boolValue"));
				break;
			case ValueType.String:
				EditorGUI.PropertyField (rc, property.FindPropertyRelative("stringValue"));
				break;
			case ValueType.Object:
				EditorGUI.PropertyField (rc, property.FindPropertyRelative("objectReference"));
				break;
			case ValueType.ObjectArray:
				EditorGUI.PropertyField (rc, property.FindPropertyRelative("objectArray"));
				break;
			}
			EditorGUI.EndProperty();
		}
	}
}
