﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Currs8__lab6_Autentificare.Models
{

	public class MustBeTrue : ValidationAttribute
	{
		public override bool IsValid(object value)
		{
			return value is bool && (bool)value;
		}

	}
	
}