using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_SoftJointLimit : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.SoftJointLimit o;
		o=new UnityEngine.SoftJointLimit();
		pushValue(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_limit(IntPtr l) {
		UnityEngine.SoftJointLimit self;
		checkValueType(l,1,out self);
		pushValue(l,self.limit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_limit(IntPtr l) {
		UnityEngine.SoftJointLimit self;
		checkValueType(l,1,out self);
		float v;
		checkType(l,2,out v);
		self.limit=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bounciness(IntPtr l) {
		UnityEngine.SoftJointLimit self;
		checkValueType(l,1,out self);
		pushValue(l,self.bounciness);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bounciness(IntPtr l) {
		UnityEngine.SoftJointLimit self;
		checkValueType(l,1,out self);
		float v;
		checkType(l,2,out v);
		self.bounciness=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_contactDistance(IntPtr l) {
		UnityEngine.SoftJointLimit self;
		checkValueType(l,1,out self);
		pushValue(l,self.contactDistance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_contactDistance(IntPtr l) {
		UnityEngine.SoftJointLimit self;
		checkValueType(l,1,out self);
		float v;
		checkType(l,2,out v);
		self.contactDistance=v;
		setBack(l,self);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.SoftJointLimit");
		addMember(l,"limit",get_limit,set_limit,true);
		addMember(l,"bounciness",get_bounciness,set_bounciness,true);
		addMember(l,"contactDistance",get_contactDistance,set_contactDistance,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.SoftJointLimit),typeof(System.ValueType));
	}
}
