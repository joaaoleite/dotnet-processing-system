﻿using System;
namespace DADStorm{

	public interface IPM{

		void log(string text);
		Operator get_operator_by_id(string op_id);

	}
}
