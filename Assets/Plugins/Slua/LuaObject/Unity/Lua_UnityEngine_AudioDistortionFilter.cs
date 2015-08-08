using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AudioDistortionFilter : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.AudioDistortionFilter o;
		o=new UnityEngine.AudioDistortionFilter();
		pushValue(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_distortionLevel(IntPtr l) {
		UnityEngine.AudioDistortionFilter self=(UnityEngine.AudioDistortionFilter)checkSelf(l);
		pushValue(l,self.distortionLevel);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_distortionLevel(IntPtr l) {
		UnityEngine.AudioDistortionFilter self=(UnityEngine.AudioDistortionFilter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		self.distortionLevel=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AudioDistortionFilter");
		addMember(l,"distortionLevel",get_distortionLevel,set_distortionLevel,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AudioDistortionFilter),typeof(UnityEngine.Behaviour));
	}
}
