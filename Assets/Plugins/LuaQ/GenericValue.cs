namespace LuaQ {

	using UnityEngine;

	[System.Serializable]
	public struct GenericValue {
		public ValueType valueType;
		public int intValue;
		public float floatValue;
		public bool boolValue;
		public string stringValue;
		public Object objectReference;
		public Object[] objectArray;

		public object GetValue () {
			switch (valueType) {
			case ValueType.Int:
				return intValue;
			case ValueType.Float:
				return floatValue;
			case ValueType.Bool:
				return boolValue;
			case ValueType.String:
				return stringValue;
			case ValueType.Object:
				return objectReference;
			case ValueType.ObjectArray:
				return objectArray;
			}
			return null;
		}
	}

	public enum ValueType {
		Int,
		Float,
		Bool,
		String,
		Object,
		ObjectArray
	}
}
