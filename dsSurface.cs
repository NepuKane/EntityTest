//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由T4模板自动生成
//	   生成时间 2017-07-14 16:00:57 by NEPU.LiGH
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
namespace Anydrill.UBD.Models
{
	/// <summary>
    /// 实体-dsSurface 
    /// </summary>
	public class dsSurface
    {
		[System.ComponentModel.DataAnnotations.KeyAttribute]
        public Guid ID { get; set; }
        public double? Temperature { get; set; }
        public double? BackPress { get; set; }
        public double? AtmosphericPressure { get; set; }
        public double? Altitude { get; set; }
        public int? UnDefine1 { get; set; }
        public double? UnDefine2 { get; set; }
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(50)]
        public string UnDefine3 { get; set; }
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(50)]
        public string UnDefine4 { get; set; }
	}
}


