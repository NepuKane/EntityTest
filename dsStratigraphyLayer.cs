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
    /// 实体-dsStratigraphyLayer 
    /// </summary>
	public class dsStratigraphyLayer
    {
		[System.ComponentModel.DataAnnotations.KeyAttribute]
        public Guid ID { get; set; }
        public double? TopDepth { get; set; }
        public double? Thickness { get; set; }
        public string ComplexNotation { get; set; }
        public string RockMaterial { get; set; }
        public double? Density { get; set; }
        public double? GeothermalGradient { get; set; }
        public double? PorePressGradient { get; set; }
        public double? CollapsePressGradient { get; set; }
        public double? FracturePressGradient { get; set; }
        public Guid StratigraphyID { get; set; }
	}
}


