using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AudioHighPassFilter : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.AudioHighPassFilter o;
		o=new UnityEngine.AudioHighPassFilter();
		pushValue(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cutoffFrequency(IntPtr l) {
		UnityEngine.AudioHighPassFilter self=(UnityEngine.AudioHighPassFilter)checkSelf(l);
		pushValue(l,self.cutoffFrequency);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cutoffFrequency(IntPtr l) {
		UnityEngine.AudioHighPassFilter self=(UnityEngine.AudioHighPassFilter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		self.cutoffFrequency=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_highpassResonanceQ(IntPtr l) {
		UnityEngine.AudioHighPassFilter self=(UnityEngine.AudioHighPassFilter)checkSelf(l);
		pushValue(l,self.highpassResonanceQ);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_highpassResonanceQ(IntPtr l) {
		UnityEngine.AudioHighPassFilter self=(UnityEngine.AudioHighPassFilter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		self.highpassResonanceQ=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AudioHighPassFilter");
		addMember(l,"cutoffFrequency",get_cutoffFrequency,set_cutoffFrequency,true);
		addMember(l,"highpassResonanceQ",get_highpassResonanceQ,set_highpassResonanceQ,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AudioHighPassFilter),typeof(UnityEngine.Behaviour));
	}
}
