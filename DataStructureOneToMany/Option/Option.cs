﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureOneToMany.Option
{
	public abstract class Option<T>
	{
		public static implicit operator Option<T>(T value) => new Some<T>(value);
		public static implicit operator Option<T>(None none) => new None<T>();
	}
}
