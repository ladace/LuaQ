namespace LuaQ {

	using UnityEngine;
	using System;
	using System.Reflection;
	using System.Collections.Generic;
	using SLua;
	using LuaInterface;

	[AddComponentMenu("LuaQ/Local Script")]
	public class LocalScript : MonoBehaviour {
		[TextArea(20, 30)]
		public string code;

		private LuaState luaState;
		private LuaFunction updateFunc;
		
		static public LuaCSFunction errorCSFunc = new LuaCSFunction(errorReport);

		private void InitializeLuaState () {
			luaState = new LuaState ();
			LuaState.pcall(luaState.L, Utils.init);
		}

		void Start () {
			InitializeLuaState ();
			luaState.doString (code);

			updateFunc = (LuaFunction) luaState ["update"];
		}

		void Update () {
			if (updateFunc != null)
				CallFunction (updateFunc);
		}

		private void CallFunction (LuaFunction func) {
			
			if (!LuaState.get(luaState.L).isMainThread())
			{
				Debug.LogError("Can't call lua function in bg thread");
				return;
			}

			LuaObject.pushValue (luaState.L, gameObject);
			LuaDLL.lua_pushcclosure(luaState.L, errorCSFunc, 1);
			int errorFunc = LuaDLL.lua_gettop(luaState.L);

			func.pcall (0, errorFunc);
			
			LuaDLL.lua_remove(luaState.L, errorFunc);
		}


		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		public static int errorReport(IntPtr L)
		{
			LuaDLL.lua_getglobal(L, "debug");
			LuaDLL.lua_getfield(L, -1, "traceback");
			LuaDLL.lua_pushvalue(L, 1);
			LuaDLL.lua_pushnumber(L, 2);
			LuaDLL.lua_call(L, 2, 1);
			LuaDLL.lua_remove(L, -2);

			GameObject go;
			LuaObject.checkType(L,LuaDLL.lua_upvalueindex (1),out go);

			Debug.LogError(LuaDLL.lua_tostring(L, -1), go);
			LuaDLL.lua_pop(L, 1);
			return 0;
		}
	}
}