using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Resolution : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.Resolution o;
		o=new UnityEngine.Resolution();
		pushValue(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_width(IntPtr l) {
		UnityEngine.Resolution self;
		checkValueType(l,1,out self);
		pushValue(l,self.width);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_width(IntPtr l) {
		UnityEngine.Resolution self;
		checkValueType(l,1,out self);
		int v;
		checkType(l,2,out v);
		self.width=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		UnityEngine.Resolution self;
		checkValueType(l,1,out self);
		pushValue(l,self.height);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_height(IntPtr l) {
		UnityEngine.Resolution self;
		checkValueType(l,1,out self);
		int v;
		checkType(l,2,out v);
		self.height=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_refreshRate(IntPtr l) {
		UnityEngine.Resolution self;
		checkValueType(l,1,out self);
		pushValue(l,self.refreshRate);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_refreshRate(IntPtr l) {
		UnityEngine.Resolution self;
		checkValueType(l,1,out self);
		int v;
		checkType(l,2,out v);
		self.refreshRate=v;
		setBack(l,self);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Resolution");
		addMember(l,"width",get_width,set_width,true);
		addMember(l,"height",get_height,set_height,true);
		addMember(l,"refreshRate",get_refreshRate,set_refreshRate,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Resolution),typeof(System.ValueType));
	}
}
