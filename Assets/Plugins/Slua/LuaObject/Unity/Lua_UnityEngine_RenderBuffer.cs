using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_RenderBuffer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.RenderBuffer o;
		o=new UnityEngine.RenderBuffer();
		pushValue(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetNativeRenderBufferPtr(IntPtr l) {
		UnityEngine.RenderBuffer self;
		checkValueType(l,1,out self);
		var ret=self.GetNativeRenderBufferPtr();
		pushValue(l,ret);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.RenderBuffer");
		addMember(l,GetNativeRenderBufferPtr);
		createTypeMetatable(l,constructor, typeof(UnityEngine.RenderBuffer),typeof(System.ValueType));
	}
}
