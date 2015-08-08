using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_UIBehaviour : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsActive(IntPtr l) {
		UnityEngine.EventSystems.UIBehaviour self=(UnityEngine.EventSystems.UIBehaviour)checkSelf(l);
		var ret=self.IsActive();
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsDestroyed(IntPtr l) {
		UnityEngine.EventSystems.UIBehaviour self=(UnityEngine.EventSystems.UIBehaviour)checkSelf(l);
		var ret=self.IsDestroyed();
		pushValue(l,ret);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.UIBehaviour");
		addMember(l,IsActive);
		addMember(l,IsDestroyed);
		createTypeMetatable(l,null, typeof(UnityEngine.EventSystems.UIBehaviour),typeof(UnityEngine.MonoBehaviour));
	}
}
