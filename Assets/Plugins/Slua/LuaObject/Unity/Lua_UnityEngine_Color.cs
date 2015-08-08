﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Color : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		UnityEngine.Color o;
		if(argc==5){
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			System.Single a4;
			checkType(l,5,out a4);
			o=new UnityEngine.Color(a1,a2,a3,a4);
			pushValue(l,o);
			return 1;
		}
		else if(argc==4){
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			o=new UnityEngine.Color(a1,a2,a3);
			pushValue(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ToHexStringRGB(IntPtr l) {
		UnityEngine.Color self;
		checkType(l,1,out self);
		var ret=self.ToHexStringRGB();
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ToHexStringRGBA(IntPtr l) {
		UnityEngine.Color self;
		checkType(l,1,out self);
		var ret=self.ToHexStringRGBA();
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int TryParseHexString_s(IntPtr l) {
		System.String a1;
		checkType(l,1,out a1);
		UnityEngine.Color a2;
		var ret=UnityEngine.Color.TryParseHexString(a1,out a2);
		pushValue(l,ret);
		pushValue(l,a2);
		return 2;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Lerp_s(IntPtr l) {
		UnityEngine.Color a1;
		checkType(l,1,out a1);
		UnityEngine.Color a2;
		checkType(l,2,out a2);
		System.Single a3;
		checkType(l,3,out a3);
		var ret=UnityEngine.Color.Lerp(a1,a2,a3);
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Addition(IntPtr l) {
		UnityEngine.Color a1;
		checkType(l,1,out a1);
		UnityEngine.Color a2;
		checkType(l,2,out a2);
		var ret=a1+a2;
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Subtraction(IntPtr l) {
		UnityEngine.Color a1;
		checkType(l,1,out a1);
		UnityEngine.Color a2;
		checkType(l,2,out a2);
		var ret=a1-a2;
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Multiply(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		if(matchType(l,argc,1,typeof(float),typeof(UnityEngine.Color))){
			System.Single a1;
			checkType(l,1,out a1);
			UnityEngine.Color a2;
			checkType(l,2,out a2);
			var ret=a1*a2;
			pushValue(l,ret);
			return 1;
		}
		else if(matchType(l,argc,1,typeof(UnityEngine.Color),typeof(float))){
			UnityEngine.Color a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			var ret=a1*a2;
			pushValue(l,ret);
			return 1;
		}
		else if(matchType(l,argc,1,typeof(UnityEngine.Color),typeof(UnityEngine.Color))){
			UnityEngine.Color a1;
			checkType(l,1,out a1);
			UnityEngine.Color a2;
			checkType(l,2,out a2);
			var ret=a1*a2;
			pushValue(l,ret);
			return 1;
		}
		LuaDLL.luaL_error(l,"No matched override function to call");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Division(IntPtr l) {
		UnityEngine.Color a1;
		checkType(l,1,out a1);
		System.Single a2;
		checkType(l,2,out a2);
		var ret=a1/a2;
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Equality(IntPtr l) {
		UnityEngine.Color a1;
		checkType(l,1,out a1);
		UnityEngine.Color a2;
		checkType(l,2,out a2);
		var ret=(a1==a2);
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Inequality(IntPtr l) {
		UnityEngine.Color a1;
		checkType(l,1,out a1);
		UnityEngine.Color a2;
		checkType(l,2,out a2);
		var ret=(a1!=a2);
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_r(IntPtr l) {
		UnityEngine.Color self;
		checkType(l,1,out self);
		pushValue(l,self.r);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_r(IntPtr l) {
		UnityEngine.Color self;
		checkType(l,1,out self);
		System.Single v;
		checkType(l,2,out v);
		self.r=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_g(IntPtr l) {
		UnityEngine.Color self;
		checkType(l,1,out self);
		pushValue(l,self.g);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_g(IntPtr l) {
		UnityEngine.Color self;
		checkType(l,1,out self);
		System.Single v;
		checkType(l,2,out v);
		self.g=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_b(IntPtr l) {
		UnityEngine.Color self;
		checkType(l,1,out self);
		pushValue(l,self.b);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_b(IntPtr l) {
		UnityEngine.Color self;
		checkType(l,1,out self);
		System.Single v;
		checkType(l,2,out v);
		self.b=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_a(IntPtr l) {
		UnityEngine.Color self;
		checkType(l,1,out self);
		pushValue(l,self.a);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_a(IntPtr l) {
		UnityEngine.Color self;
		checkType(l,1,out self);
		System.Single v;
		checkType(l,2,out v);
		self.a=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_red(IntPtr l) {
		pushValue(l,UnityEngine.Color.red);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_green(IntPtr l) {
		pushValue(l,UnityEngine.Color.green);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_blue(IntPtr l) {
		pushValue(l,UnityEngine.Color.blue);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_white(IntPtr l) {
		pushValue(l,UnityEngine.Color.white);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_black(IntPtr l) {
		pushValue(l,UnityEngine.Color.black);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_yellow(IntPtr l) {
		pushValue(l,UnityEngine.Color.yellow);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cyan(IntPtr l) {
		pushValue(l,UnityEngine.Color.cyan);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_magenta(IntPtr l) {
		pushValue(l,UnityEngine.Color.magenta);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gray(IntPtr l) {
		pushValue(l,UnityEngine.Color.gray);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_grey(IntPtr l) {
		pushValue(l,UnityEngine.Color.grey);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clear(IntPtr l) {
		pushValue(l,UnityEngine.Color.clear);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_grayscale(IntPtr l) {
		UnityEngine.Color self;
		checkType(l,1,out self);
		pushValue(l,self.grayscale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_linear(IntPtr l) {
		UnityEngine.Color self;
		checkType(l,1,out self);
		pushValue(l,self.linear);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gamma(IntPtr l) {
		UnityEngine.Color self;
		checkType(l,1,out self);
		pushValue(l,self.gamma);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxColorComponent(IntPtr l) {
		UnityEngine.Color self;
		checkType(l,1,out self);
		pushValue(l,self.maxColorComponent);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int getItem(IntPtr l) {
		UnityEngine.Color self;
		checkType(l,1,out self);
		int v;
		checkType(l,2,out v);
		var ret = self[v];
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setItem(IntPtr l) {
		UnityEngine.Color self;
		checkType(l,1,out self);
		int v;
		checkType(l,2,out v);
		float c;
		checkType(l,3,out c);
		self[v]=c;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Color");
		addMember(l,ToHexStringRGB);
		addMember(l,ToHexStringRGBA);
		addMember(l,TryParseHexString_s);
		addMember(l,Lerp_s);
		addMember(l,op_Addition);
		addMember(l,op_Subtraction);
		addMember(l,op_Multiply);
		addMember(l,op_Division);
		addMember(l,op_Equality);
		addMember(l,op_Inequality);
		addMember(l,getItem);
		addMember(l,setItem);
		addMember(l,"r",get_r,set_r,true);
		addMember(l,"g",get_g,set_g,true);
		addMember(l,"b",get_b,set_b,true);
		addMember(l,"a",get_a,set_a,true);
		addMember(l,"red",get_red,null,false);
		addMember(l,"green",get_green,null,false);
		addMember(l,"blue",get_blue,null,false);
		addMember(l,"white",get_white,null,false);
		addMember(l,"black",get_black,null,false);
		addMember(l,"yellow",get_yellow,null,false);
		addMember(l,"cyan",get_cyan,null,false);
		addMember(l,"magenta",get_magenta,null,false);
		addMember(l,"gray",get_gray,null,false);
		addMember(l,"grey",get_grey,null,false);
		addMember(l,"clear",get_clear,null,false);
		addMember(l,"grayscale",get_grayscale,null,true);
		addMember(l,"linear",get_linear,null,true);
		addMember(l,"gamma",get_gamma,null,true);
		addMember(l,"maxColorComponent",get_maxColorComponent,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Color),typeof(System.ValueType));
	}
}
