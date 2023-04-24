//using System;
//using TestRamsay.Core.DTOs;
//using TestRamsay.Data;
//using TestRamsay.Data.Implementations;
//using TestRamsay.Data.Interfaces;

//namespace TestRamsay.Bussiness
//{
//	public class GenderBL
//	{
//		private readonly IGenderRepository _gender;
//		public GenderBL(IGenderRepository gender)
//		{
//			this._gender = gender;
//		}

//        public GenderDTO Create(GenderDTO gender)
//		{
//			return this._gender.Create(gender);
//		}
//	}
//}