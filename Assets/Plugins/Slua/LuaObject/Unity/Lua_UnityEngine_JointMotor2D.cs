using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_JointMotor2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.JointMotor2D o;
		o=new UnityEngine.JointMotor2D();
		pushValue(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_motorSpeed(IntPtr l) {
		UnityEngine.JointMotor2D self;
		checkValueType(l,1,out self);
		pushValue(l,self.motorSpeed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_motorSpeed(IntPtr l) {
		UnityEngine.JointMotor2D self;
		checkValueType(l,1,out self);
		float v;
		checkType(l,2,out v);
		self.motorSpeed=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxMotorTorque(IntPtr l) {
		UnityEngine.JointMotor2D self;
		checkValueType(l,1,out self);
		pushValue(l,self.maxMotorTorque);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxMotorTorque(IntPtr l) {
		UnityEngine.JointMotor2D self;
		checkValueType(l,1,out self);
		float v;
		checkType(l,2,out v);
		self.maxMotorTorque=v;
		setBack(l,self);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.JointMotor2D");
		addMember(l,"motorSpeed",get_motorSpeed,set_motorSpeed,true);
		addMember(l,"maxMotorTorque",get_maxMotorTorque,set_maxMotorTorque,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.JointMotor2D),typeof(System.ValueType));
	}
}
