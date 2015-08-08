using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_VR_VRDevice : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.VR.VRDevice o;
		o=new UnityEngine.VR.VRDevice();
		pushValue(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetNativePtr_s(IntPtr l) {
		var ret=UnityEngine.VR.VRDevice.GetNativePtr();
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isPresent(IntPtr l) {
		pushValue(l,UnityEngine.VR.VRDevice.isPresent);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_family(IntPtr l) {
		pushValue(l,UnityEngine.VR.VRDevice.family);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_model(IntPtr l) {
		pushValue(l,UnityEngine.VR.VRDevice.model);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.VR.VRDevice");
		addMember(l,GetNativePtr_s);
		addMember(l,"isPresent",get_isPresent,null,false);
		addMember(l,"family",get_family,null,false);
		addMember(l,"model",get_model,null,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.VR.VRDevice));
	}
}
