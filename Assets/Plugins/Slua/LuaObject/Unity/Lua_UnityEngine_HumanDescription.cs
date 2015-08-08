using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_HumanDescription : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.HumanDescription o;
		o=new UnityEngine.HumanDescription();
		pushValue(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_human(IntPtr l) {
		UnityEngine.HumanDescription self;
		checkValueType(l,1,out self);
		pushValue(l,self.human);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_human(IntPtr l) {
		UnityEngine.HumanDescription self;
		checkValueType(l,1,out self);
		UnityEngine.HumanBone[] v;
		checkType(l,2,out v);
		self.human=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_skeleton(IntPtr l) {
		UnityEngine.HumanDescription self;
		checkValueType(l,1,out self);
		pushValue(l,self.skeleton);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_skeleton(IntPtr l) {
		UnityEngine.HumanDescription self;
		checkValueType(l,1,out self);
		UnityEngine.SkeletonBone[] v;
		checkType(l,2,out v);
		self.skeleton=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_upperArmTwist(IntPtr l) {
		UnityEngine.HumanDescription self;
		checkValueType(l,1,out self);
		pushValue(l,self.upperArmTwist);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_upperArmTwist(IntPtr l) {
		UnityEngine.HumanDescription self;
		checkValueType(l,1,out self);
		float v;
		checkType(l,2,out v);
		self.upperArmTwist=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lowerArmTwist(IntPtr l) {
		UnityEngine.HumanDescription self;
		checkValueType(l,1,out self);
		pushValue(l,self.lowerArmTwist);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lowerArmTwist(IntPtr l) {
		UnityEngine.HumanDescription self;
		checkValueType(l,1,out self);
		float v;
		checkType(l,2,out v);
		self.lowerArmTwist=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_upperLegTwist(IntPtr l) {
		UnityEngine.HumanDescription self;
		checkValueType(l,1,out self);
		pushValue(l,self.upperLegTwist);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_upperLegTwist(IntPtr l) {
		UnityEngine.HumanDescription self;
		checkValueType(l,1,out self);
		float v;
		checkType(l,2,out v);
		self.upperLegTwist=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lowerLegTwist(IntPtr l) {
		UnityEngine.HumanDescription self;
		checkValueType(l,1,out self);
		pushValue(l,self.lowerLegTwist);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lowerLegTwist(IntPtr l) {
		UnityEngine.HumanDescription self;
		checkValueType(l,1,out self);
		float v;
		checkType(l,2,out v);
		self.lowerLegTwist=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_armStretch(IntPtr l) {
		UnityEngine.HumanDescription self;
		checkValueType(l,1,out self);
		pushValue(l,self.armStretch);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_armStretch(IntPtr l) {
		UnityEngine.HumanDescription self;
		checkValueType(l,1,out self);
		float v;
		checkType(l,2,out v);
		self.armStretch=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_legStretch(IntPtr l) {
		UnityEngine.HumanDescription self;
		checkValueType(l,1,out self);
		pushValue(l,self.legStretch);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_legStretch(IntPtr l) {
		UnityEngine.HumanDescription self;
		checkValueType(l,1,out self);
		float v;
		checkType(l,2,out v);
		self.legStretch=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_feetSpacing(IntPtr l) {
		UnityEngine.HumanDescription self;
		checkValueType(l,1,out self);
		pushValue(l,self.feetSpacing);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_feetSpacing(IntPtr l) {
		UnityEngine.HumanDescription self;
		checkValueType(l,1,out self);
		float v;
		checkType(l,2,out v);
		self.feetSpacing=v;
		setBack(l,self);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.HumanDescription");
		addMember(l,"human",get_human,set_human,true);
		addMember(l,"skeleton",get_skeleton,set_skeleton,true);
		addMember(l,"upperArmTwist",get_upperArmTwist,set_upperArmTwist,true);
		addMember(l,"lowerArmTwist",get_lowerArmTwist,set_lowerArmTwist,true);
		addMember(l,"upperLegTwist",get_upperLegTwist,set_upperLegTwist,true);
		addMember(l,"lowerLegTwist",get_lowerLegTwist,set_lowerLegTwist,true);
		addMember(l,"armStretch",get_armStretch,set_armStretch,true);
		addMember(l,"legStretch",get_legStretch,set_legStretch,true);
		addMember(l,"feetSpacing",get_feetSpacing,set_feetSpacing,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.HumanDescription),typeof(System.ValueType));
	}
}
