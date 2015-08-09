using UnityEngine;
using System.Collections;

[SLua.CustomLuaClass]
public class LocalScriptBase : MonoBehaviour {
	public virtual void delayInvoke (string methodName, float delay) {}
}
