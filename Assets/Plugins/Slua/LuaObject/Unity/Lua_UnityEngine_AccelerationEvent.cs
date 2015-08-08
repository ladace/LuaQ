using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AccelerationEvent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.AccelerationEvent o;
		o=new UnityEngine.AccelerationEvent();
		pushValue(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_acceleration(IntPtr l) {
		UnityEngine.AccelerationEvent self;
		checkValueType(l,1,out self);
		pushValue(l,self.acceleration);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_deltaTime(IntPtr l) {
		UnityEngine.AccelerationEvent self;
		checkValueType(l,1,out self);
		pushValue(l,self.deltaTime);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AccelerationEvent");
		addMember(l,"acceleration",get_acceleration,null,true);
		addMember(l,"deltaTime",get_deltaTime,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AccelerationEvent),typeof(System.ValueType));
	}
}
