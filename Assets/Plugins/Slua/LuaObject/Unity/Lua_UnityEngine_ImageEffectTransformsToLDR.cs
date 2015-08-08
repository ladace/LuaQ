using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ImageEffectTransformsToLDR : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.ImageEffectTransformsToLDR o;
		o=new UnityEngine.ImageEffectTransformsToLDR();
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ImageEffectTransformsToLDR");
		createTypeMetatable(l,constructor, typeof(UnityEngine.ImageEffectTransformsToLDR),typeof(System.Attribute));
	}
}
