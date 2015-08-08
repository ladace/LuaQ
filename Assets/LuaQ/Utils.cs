namespace LuaQ {
	
	using UnityEngine;
	using System;
	using System.Reflection;
	using System.Collections.Generic;
	using SLua;
	using LuaInterface;

	internal class Utils {
		
		static public int init(IntPtr L)
		{
			LuaObject.init(L);
			bindAll(L);
			LuaTimer.reg(L);
			Helper.reg(L);
			LuaValueType.reg(L);
			SLuaDebug.reg(L);
			LuaDLL.luaS_openextlibs(L);
			return 0;
		}
		
		static public void bindAll(IntPtr l)
		{
			// add RELEASE macro to switch on below codes
			#if RELEASE && (UNITY_IOS || UNITY_ANDROID)
			BindUnity.Bind(l);
			BindUnityUI.Bind(l); // delete this line if not found
			BindDll.Bind(l); // delete this line if not found
			BindCustom.Bind(l); 
			#else
			Assembly[] ams = AppDomain.CurrentDomain.GetAssemblies();
			
			List<Type> bindlist = new List<Type>();
			foreach(Assembly a in ams) 
			{
				Type[] ts=a.GetExportedTypes();
				foreach (Type t in ts)
				{
					if (t.GetCustomAttributes(typeof(LuaBinderAttribute),false).Length > 0)
					{
						bindlist.Add(t);
					}
				}
			}
			
			bindlist.Sort( new System.Comparison<Type>((Type a,Type b) =>
			                                           {
				LuaBinderAttribute la = (LuaBinderAttribute)a.GetCustomAttributes(typeof(LuaBinderAttribute),false)[0];
				LuaBinderAttribute lb = (LuaBinderAttribute)b.GetCustomAttributes(typeof(LuaBinderAttribute),false)[0];
				
				return la.order.CompareTo(lb.order);
			})
			              );
			
			foreach (Type t in bindlist)
			{
				t.GetMethod("Bind").Invoke(null, new object[] { l });
			}
			#endif
		}
	}
}