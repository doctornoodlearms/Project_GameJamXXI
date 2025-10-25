using System;
using Definitions.Potions;

namespace Definitions;

public static class DefintionBuilder {

	public static Potion BuildPotion(StringName id) {

		Type def = Type.GetType(id);
		return (Potion)Activator.CreateInstance(def);
	}
}