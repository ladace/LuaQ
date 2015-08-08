using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_JointSuspension2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.JointSuspension2D o;
		o=new UnityEngine.JointSuspension2D();
		pushValue(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dampingRatio(IntPtr l) {
		UnityEngine.JointSuspension2D self;
		checkValueType(l,1,out self);
		pushValue(l,self.dampingRatio);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dampingRatio(IntPtr l) {
		UnityEngine.JointSuspension2D self;
		checkValueType(l,1,out self);
		float v;
		checkType(l,2,out v);
		self.dampingRatio=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_frequency(IntPtr l) {
		UnityEngine.JointSuspension2D self;
		checkValueType(l,1,out self);
		pushValue(l,self.frequency);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_frequency(IntPtr l) {
		UnityEngine.JointSuspension2D self;
		checkValueType(l,1,out self);
		float v;
		checkType(l,2,out v);
		self.frequency=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angle(IntPtr l) {
		UnityEngine.JointSuspension2D self;
		checkValueType(l,1,out self);
		pushValue(l,self.angle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angle(IntPtr l) {
		UnityEngine.JointSuspension2D self;
		checkValueType(l,1,out self);
		float v;
		checkType(l,2,out v);
		self.angle=v;
		setBack(l,self);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.JointSuspension2D");
		addMember(l,"dampingRatio",get_dampingRatio,set_dampingRatio,true);
		addMember(l,"frequency",get_frequency,set_frequency,true);
		addMember(l,"angle",get_angle,set_angle,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.JointSuspension2D),typeof(System.ValueType));
	}
}
