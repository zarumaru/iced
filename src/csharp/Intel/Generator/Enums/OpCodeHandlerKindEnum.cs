/*
Copyright (C) 2018-2019 de4dot@gmail.com

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

namespace Generator.Enums {
	static class OpCodeHandlerKindEnum {
		const string? documentation = null;

		static EnumValue[] GetValues() =>
			new EnumValue[] {
				new EnumValue("Bitness"),
				new EnumValue("Bitness_DontReadModRM"),
				new EnumValue("Invalid"),
				new EnumValue("Invalid_NoModRM"),
				new EnumValue("Invalid2"),
				new EnumValue("Dup"),
				new EnumValue("Null"),
				new EnumValue("HandlerReference"),
				new EnumValue("ArrayReference"),
				new EnumValue("RM"),
				new EnumValue("Options3"),
				new EnumValue("Options5"),
				new EnumValue("Options_DontReadModRM"),
				new EnumValue("AnotherTable"),
				new EnumValue("Group"),
				new EnumValue("Group8x64"),
				new EnumValue("Group8x8"),
				new EnumValue("MandatoryPrefix"),
				new EnumValue("MandatoryPrefix_F3_F2"),
				new EnumValue("LegacyMandatoryPrefix_F3_F2"),
				new EnumValue("MandatoryPrefix_NoModRM"),
				new EnumValue("MandatoryPrefix3"),
				new EnumValue("D3NOW"),
				new EnumValue("EVEX"),
				new EnumValue("VEX2"),
				new EnumValue("VEX3"),
				new EnumValue("XOP"),
				new EnumValue("AL_DX"),
				new EnumValue("Ap"),
				new EnumValue("B_BM"),
				new EnumValue("B_Ev"),
				new EnumValue("B_MIB"),
				new EnumValue("BM_B"),
				new EnumValue("BranchIw"),
				new EnumValue("BranchSimple"),
				new EnumValue("C_R_3a"),
				new EnumValue("C_R_3b"),
				new EnumValue("DX_AL"),
				new EnumValue("DX_eAX"),
				new EnumValue("eAX_DX"),
				new EnumValue("Eb_1"),
				new EnumValue("Eb_2"),
				new EnumValue("Eb_CL"),
				new EnumValue("Eb_Gb_1"),
				new EnumValue("Eb_Gb_2"),
				new EnumValue("Eb_Ib_1"),
				new EnumValue("Eb_Ib_2"),
				new EnumValue("Eb1"),
				new EnumValue("Ed_V_Ib"),
				new EnumValue("Ep"),
				new EnumValue("Ev_3a"),
				new EnumValue("Ev_3b"),
				new EnumValue("Ev_4"),
				new EnumValue("Ev_CL"),
				new EnumValue("Ev_Gv_32_64"),
				new EnumValue("Ev_Gv_3a"),
				new EnumValue("Ev_Gv_3b"),
				new EnumValue("Ev_Gv_4"),
				new EnumValue("Ev_Gv_CL"),
				new EnumValue("Ev_Gv_Ib"),
				new EnumValue("Ev_Gv_REX"),
				new EnumValue("Ev_Ib_3"),
				new EnumValue("Ev_Ib_4"),
				new EnumValue("Ev_Ib2_3"),
				new EnumValue("Ev_Ib2_4"),
				new EnumValue("Ev_Iz_3"),
				new EnumValue("Ev_Iz_4"),
				new EnumValue("Ev_P"),
				new EnumValue("Ev_REXW"),
				new EnumValue("Ev_Sw"),
				new EnumValue("Ev_VX"),
				new EnumValue("Ev1"),
				new EnumValue("Evj"),
				new EnumValue("Evw"),
				new EnumValue("Ew"),
				new EnumValue("Gb_Eb"),
				new EnumValue("Gdq_Ev"),
				new EnumValue("Gv_Eb"),
				new EnumValue("Gv_Eb_REX"),
				new EnumValue("Gv_Ev_32_64"),
				new EnumValue("Gv_Ev_3a"),
				new EnumValue("Gv_Ev_3b"),
				new EnumValue("Gv_Ev_Ib"),
				new EnumValue("Gv_Ev_Ib_REX"),
				new EnumValue("Gv_Ev_Iz"),
				new EnumValue("Gv_Ev_REX"),
				new EnumValue("Gv_Ev2"),
				new EnumValue("Gv_Ev3"),
				new EnumValue("Gv_Ew"),
				new EnumValue("Gv_M"),
				new EnumValue("Gv_M_as"),
				new EnumValue("Gv_Ma"),
				new EnumValue("Gv_Mp_2"),
				new EnumValue("Gv_Mp_3"),
				new EnumValue("Gv_Mv"),
				new EnumValue("Gv_N"),
				new EnumValue("Gv_N_Ib_REX"),
				new EnumValue("Gv_RX"),
				new EnumValue("Gv_W"),
				new EnumValue("GvM_VX_Ib"),
				new EnumValue("Ib"),
				new EnumValue("Ib3"),
				new EnumValue("IbReg"),
				new EnumValue("IbReg2"),
				new EnumValue("Iw_Ib"),
				new EnumValue("Jb"),
				new EnumValue("Jb2"),
				new EnumValue("Jdisp"),
				new EnumValue("Jx"),
				new EnumValue("Jz"),
				new EnumValue("M_1"),
				new EnumValue("M_2"),
				new EnumValue("M_REXW_2"),
				new EnumValue("M_REXW_4"),
				new EnumValue("MemBx"),
				new EnumValue("Mf_1"),
				new EnumValue("Mf_2a"),
				new EnumValue("Mf_2b"),
				new EnumValue("MIB_B"),
				new EnumValue("MP"),
				new EnumValue("Ms"),
				new EnumValue("MV"),
				new EnumValue("Mv_Gv"),
				new EnumValue("Mv_Gv_REXW"),
				new EnumValue("NIb"),
				new EnumValue("Ob_Reg"),
				new EnumValue("Ov_Reg"),
				new EnumValue("P_Ev"),
				new EnumValue("P_Ev_Ib"),
				new EnumValue("P_Q"),
				new EnumValue("P_Q_Ib"),
				new EnumValue("P_R"),
				new EnumValue("P_W"),
				new EnumValue("PushEv"),
				new EnumValue("PushIb2"),
				new EnumValue("PushIz"),
				new EnumValue("PushOpSizeReg_4a"),
				new EnumValue("PushOpSizeReg_4b"),
				new EnumValue("PushSimple2"),
				new EnumValue("PushSimpleReg"),
				new EnumValue("Q_P"),
				new EnumValue("R_C_3a"),
				new EnumValue("R_C_3b"),
				new EnumValue("rDI_P_N"),
				new EnumValue("rDI_VX_RX"),
				new EnumValue("Reg"),
				new EnumValue("Reg_Ib2"),
				new EnumValue("Reg_Iz"),
				new EnumValue("Reg_Ob"),
				new EnumValue("Reg_Ov"),
				new EnumValue("Reg_Xb"),
				new EnumValue("Reg_Xv"),
				new EnumValue("Reg_Xv2"),
				new EnumValue("Reg_Yb"),
				new EnumValue("Reg_Yv"),
				new EnumValue("RegIb"),
				new EnumValue("RegIb3"),
				new EnumValue("RegIz2"),
				new EnumValue("ReservedNop"),
				new EnumValue("RIb"),
				new EnumValue("RIbIb"),
				new EnumValue("Rv"),
				new EnumValue("Rv_32_64"),
				new EnumValue("RvMw_Gw"),
				new EnumValue("Simple"),
				new EnumValue("Simple_ModRM"),
				new EnumValue("Simple2_3a"),
				new EnumValue("Simple2_3b"),
				new EnumValue("Simple2Iw"),
				new EnumValue("Simple3"),
				new EnumValue("Simple4"),
				new EnumValue("Simple5"),
				new EnumValue("Simple5_ModRM_as"),
				new EnumValue("SimpleReg"),
				new EnumValue("ST_STi"),
				new EnumValue("STi"),
				new EnumValue("STi_ST"),
				new EnumValue("Sw_Ev"),
				new EnumValue("V_Ev"),
				new EnumValue("VM"),
				new EnumValue("VN"),
				new EnumValue("VQ"),
				new EnumValue("VRIbIb"),
				new EnumValue("VW_2"),
				new EnumValue("VW_3"),
				new EnumValue("VWIb_2"),
				new EnumValue("VWIb_3"),
				new EnumValue("VX_E_Ib"),
				new EnumValue("VX_Ev"),
				new EnumValue("Wbinvd"),
				new EnumValue("WV"),
				new EnumValue("Xb_Yb"),
				new EnumValue("Xchg_Reg_rAX"),
				new EnumValue("Xv_Yv"),
				new EnumValue("Yb_Reg"),
				new EnumValue("Yb_Xb"),
				new EnumValue("Yv_Reg"),
				new EnumValue("Yv_Reg2"),
				new EnumValue("Yv_Xv"),
			};

		public static readonly EnumType Instance = new EnumType(TypeIds.OpCodeHandlerKind, documentation, GetValues(), EnumTypeFlags.None);
	}
}