using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AnimatorClipInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.AnimatorClipInfo o;
		o=new UnityEngine.AnimatorClipInfo();
		pushValue(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clip(IntPtr l) {
		UnityEngine.AnimatorClipInfo self;
		checkValueType(l,1,out self);
		pushValue(l,self.clip);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_weight(IntPtr l) {
		UnityEngine.AnimatorClipInfo self;
		checkValueType(l,1,out self);
		pushValue(l,self.weight);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AnimatorClipInfo");
		addMember(l,"clip",get_clip,null,true);
		addMember(l,"weight",get_weight,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AnimatorClipInfo),typeof(System.ValueType));
	}
}
