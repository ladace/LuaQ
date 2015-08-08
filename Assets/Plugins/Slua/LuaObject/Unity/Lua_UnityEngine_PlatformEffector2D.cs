﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_PlatformEffector2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.PlatformEffector2D o;
		o=new UnityEngine.PlatformEffector2D();
		pushValue(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useOneWay(IntPtr l) {
		UnityEngine.PlatformEffector2D self=(UnityEngine.PlatformEffector2D)checkSelf(l);
		pushValue(l,self.useOneWay);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useOneWay(IntPtr l) {
		UnityEngine.PlatformEffector2D self=(UnityEngine.PlatformEffector2D)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		self.useOneWay=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useSideFriction(IntPtr l) {
		UnityEngine.PlatformEffector2D self=(UnityEngine.PlatformEffector2D)checkSelf(l);
		pushValue(l,self.useSideFriction);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useSideFriction(IntPtr l) {
		UnityEngine.PlatformEffector2D self=(UnityEngine.PlatformEffector2D)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		self.useSideFriction=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useSideBounce(IntPtr l) {
		UnityEngine.PlatformEffector2D self=(UnityEngine.PlatformEffector2D)checkSelf(l);
		pushValue(l,self.useSideBounce);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useSideBounce(IntPtr l) {
		UnityEngine.PlatformEffector2D self=(UnityEngine.PlatformEffector2D)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		self.useSideBounce=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_surfaceArc(IntPtr l) {
		UnityEngine.PlatformEffector2D self=(UnityEngine.PlatformEffector2D)checkSelf(l);
		pushValue(l,self.surfaceArc);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_surfaceArc(IntPtr l) {
		UnityEngine.PlatformEffector2D self=(UnityEngine.PlatformEffector2D)checkSelf(l);
		float v;
		checkType(l,2,out v);
		self.surfaceArc=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.PlatformEffector2D");
		addMember(l,"useOneWay",get_useOneWay,set_useOneWay,true);
		addMember(l,"useSideFriction",get_useSideFriction,set_useSideFriction,true);
		addMember(l,"useSideBounce",get_useSideBounce,set_useSideBounce,true);
		addMember(l,"surfaceArc",get_surfaceArc,set_surfaceArc,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.PlatformEffector2D),typeof(UnityEngine.Effector2D));
	}
}
