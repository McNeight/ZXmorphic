﻿namespace Morphic.Core.CPU.Z80
{
	public partial class Z80CPU
	{
		protected void InitializeGeneratedOpcodeTables()
		{
			// 8-bit register operations
			op[0x04] = new Op("INC B", delegate { B = INC(B); });
			op[0x05] = new Op("DEC B", delegate { B = DEC(B); });
			op[0x06] = new Op("LD B,n", delegate { B = n; });
			opED[0x40] = new Op("IN B,(C)", delegate { B = io.ReadByte(C); });
			opED[0x41] = new Op("OUT (C),B", delegate { OUT(C, B); });
			op[0x40] = new Op("LD B,B", delegate { B = B; });
			op[0x41] = new Op("LD B,C", delegate { B = C; });
			op[0x42] = new Op("LD B,D", delegate { B = D; });
			op[0x43] = new Op("LD B,E", delegate { B = E; });
			op[0x44] = new Op("LD B,H", delegate { B = H; });
			op[0x45] = new Op("LD B,L", delegate { B = L; });
			op[0x46] = new Op("LD B,(HL)", delegate { B = HLAddr; });
			op[0x47] = new Op("LD B,A", delegate { B = A; });
			op[0x78] = new Op("LD A,B", delegate { A = B; });
			opCB[0x40] = new Op("BIT 0,B", delegate { BIT(0, B); });
			opCB[0x80] = new Op("RES 0,B", delegate { B = RES(0, B); });
			opCB[0xc0] = new Op("SET 0,B", delegate { B = SET(0, B); });
			opCB[0x48] = new Op("BIT 1,B", delegate { BIT(1, B); });
			opCB[0x88] = new Op("RES 1,B", delegate { B = RES(1, B); });
			opCB[0xc8] = new Op("SET 1,B", delegate { B = SET(1, B); });
			opCB[0x50] = new Op("BIT 2,B", delegate { BIT(2, B); });
			opCB[0x90] = new Op("RES 2,B", delegate { B = RES(2, B); });
			opCB[0xd0] = new Op("SET 2,B", delegate { B = SET(2, B); });
			opCB[0x58] = new Op("BIT 3,B", delegate { BIT(3, B); });
			opCB[0x98] = new Op("RES 3,B", delegate { B = RES(3, B); });
			opCB[0xd8] = new Op("SET 3,B", delegate { B = SET(3, B); });
			opCB[0x60] = new Op("BIT 4,B", delegate { BIT(4, B); });
			opCB[0xa0] = new Op("RES 4,B", delegate { B = RES(4, B); });
			opCB[0xe0] = new Op("SET 4,B", delegate { B = SET(4, B); });
			opCB[0x68] = new Op("BIT 5,B", delegate { BIT(5, B); });
			opCB[0xa8] = new Op("RES 5,B", delegate { B = RES(5, B); });
			opCB[0xe8] = new Op("SET 5,B", delegate { B = SET(5, B); });
			opCB[0x70] = new Op("BIT 6,B", delegate { BIT(6, B); });
			opCB[0xb0] = new Op("RES 6,B", delegate { B = RES(6, B); });
			opCB[0xf0] = new Op("SET 6,B", delegate { B = SET(6, B); });
			opCB[0x78] = new Op("BIT 7,B", delegate { BIT(7, B); });
			opCB[0xb8] = new Op("RES 7,B", delegate { B = RES(7, B); });
			opCB[0xf8] = new Op("SET 7,B", delegate { B = SET(7, B); });
			opCB[0x00] = new Op("RLC B", delegate { B = RLC(B); });
			opCB[0x08] = new Op("RRC B", delegate { B = RRC(B); });
			opCB[0x10] = new Op("RL B", delegate { B = RL(B); });
			opCB[0x18] = new Op("RR B", delegate { B = RR(B); });
			opCB[0x20] = new Op("SLA B", delegate { B = SLA(B); });
			opCB[0x28] = new Op("SRA B", delegate { B = SRA(B); });
			opCB[0x30] = new Op("SLL B", delegate { B = SLL(B); });
			opCB[0x38] = new Op("SRL B", delegate { B = SRL(B); });
			op[0x80] = new Op("ADD B", delegate { ADD(B); });
			op[0x88] = new Op("ADC B", delegate { ADC(B); });
			op[0x90] = new Op("SUB B", delegate { SUB(B); });
			op[0x98] = new Op("SBC B", delegate { SBC(B); });
			op[0xa0] = new Op("AND B", delegate { AND(B); });
			op[0xa8] = new Op("XOR B", delegate { XOR(B); });
			op[0xb0] = new Op("OR B", delegate { OR(B); });
			op[0xb8] = new Op("CP B", delegate { CP(B); });
			op[0x0c] = new Op("INC C", delegate { C = INC(C); });
			op[0x0d] = new Op("DEC C", delegate { C = DEC(C); });
			op[0x0e] = new Op("LD C,n", delegate { C = n; });
			opED[0x48] = new Op("IN C,(C)", delegate { C = io.ReadByte(C); });
			opED[0x49] = new Op("OUT (C),C", delegate { OUT(C, C); });
			op[0x48] = new Op("LD C,B", delegate { C = B; });
			op[0x49] = new Op("LD C,C", delegate { C = C; });
			op[0x4a] = new Op("LD C,D", delegate { C = D; });
			op[0x4b] = new Op("LD C,E", delegate { C = E; });
			op[0x4c] = new Op("LD C,H", delegate { C = H; });
			op[0x4d] = new Op("LD C,L", delegate { C = L; });
			op[0x4e] = new Op("LD C,(HL)", delegate { C = HLAddr; });
			op[0x4f] = new Op("LD C,A", delegate { C = A; });
			op[0x79] = new Op("LD A,C", delegate { A = C; });
			opCB[0x41] = new Op("BIT 0,C", delegate { BIT(0, C); });
			opCB[0x81] = new Op("RES 0,C", delegate { C = RES(0, C); });
			opCB[0xc1] = new Op("SET 0,C", delegate { C = SET(0, C); });
			opCB[0x49] = new Op("BIT 1,C", delegate { BIT(1, C); });
			opCB[0x89] = new Op("RES 1,C", delegate { C = RES(1, C); });
			opCB[0xc9] = new Op("SET 1,C", delegate { C = SET(1, C); });
			opCB[0x51] = new Op("BIT 2,C", delegate { BIT(2, C); });
			opCB[0x91] = new Op("RES 2,C", delegate { C = RES(2, C); });
			opCB[0xd1] = new Op("SET 2,C", delegate { C = SET(2, C); });
			opCB[0x59] = new Op("BIT 3,C", delegate { BIT(3, C); });
			opCB[0x99] = new Op("RES 3,C", delegate { C = RES(3, C); });
			opCB[0xd9] = new Op("SET 3,C", delegate { C = SET(3, C); });
			opCB[0x61] = new Op("BIT 4,C", delegate { BIT(4, C); });
			opCB[0xa1] = new Op("RES 4,C", delegate { C = RES(4, C); });
			opCB[0xe1] = new Op("SET 4,C", delegate { C = SET(4, C); });
			opCB[0x69] = new Op("BIT 5,C", delegate { BIT(5, C); });
			opCB[0xa9] = new Op("RES 5,C", delegate { C = RES(5, C); });
			opCB[0xe9] = new Op("SET 5,C", delegate { C = SET(5, C); });
			opCB[0x71] = new Op("BIT 6,C", delegate { BIT(6, C); });
			opCB[0xb1] = new Op("RES 6,C", delegate { C = RES(6, C); });
			opCB[0xf1] = new Op("SET 6,C", delegate { C = SET(6, C); });
			opCB[0x79] = new Op("BIT 7,C", delegate { BIT(7, C); });
			opCB[0xb9] = new Op("RES 7,C", delegate { C = RES(7, C); });
			opCB[0xf9] = new Op("SET 7,C", delegate { C = SET(7, C); });
			opCB[0x01] = new Op("RLC C", delegate { C = RLC(C); });
			opCB[0x09] = new Op("RRC C", delegate { C = RRC(C); });
			opCB[0x11] = new Op("RL C", delegate { C = RL(C); });
			opCB[0x19] = new Op("RR C", delegate { C = RR(C); });
			opCB[0x21] = new Op("SLA C", delegate { C = SLA(C); });
			opCB[0x29] = new Op("SRA C", delegate { C = SRA(C); });
			opCB[0x31] = new Op("SLL C", delegate { C = SLL(C); });
			opCB[0x39] = new Op("SRL C", delegate { C = SRL(C); });
			op[0x81] = new Op("ADD C", delegate { ADD(C); });
			op[0x89] = new Op("ADC C", delegate { ADC(C); });
			op[0x91] = new Op("SUB C", delegate { SUB(C); });
			op[0x99] = new Op("SBC C", delegate { SBC(C); });
			op[0xa1] = new Op("AND C", delegate { AND(C); });
			op[0xa9] = new Op("XOR C", delegate { XOR(C); });
			op[0xb1] = new Op("OR C", delegate { OR(C); });
			op[0xb9] = new Op("CP C", delegate { CP(C); });
			op[0x14] = new Op("INC D", delegate { D = INC(D); });
			op[0x15] = new Op("DEC D", delegate { D = DEC(D); });
			op[0x16] = new Op("LD D,n", delegate { D = n; });
			opED[0x50] = new Op("IN D,(C)", delegate { D = io.ReadByte(C); });
			opED[0x51] = new Op("OUT (C),D", delegate { OUT(C, D); });
			op[0x50] = new Op("LD D,B", delegate { D = B; });
			op[0x51] = new Op("LD D,C", delegate { D = C; });
			op[0x52] = new Op("LD D,D", delegate { D = D; });
			op[0x53] = new Op("LD D,E", delegate { D = E; });
			op[0x54] = new Op("LD D,H", delegate { D = H; });
			op[0x55] = new Op("LD D,L", delegate { D = L; });
			op[0x56] = new Op("LD D,(HL)", delegate { D = HLAddr; });
			op[0x57] = new Op("LD D,A", delegate { D = A; });
			op[0x7a] = new Op("LD A,D", delegate { A = D; });
			opCB[0x42] = new Op("BIT 0,D", delegate { BIT(0, D); });
			opCB[0x82] = new Op("RES 0,D", delegate { D = RES(0, D); });
			opCB[0xc2] = new Op("SET 0,D", delegate { D = SET(0, D); });
			opCB[0x4a] = new Op("BIT 1,D", delegate { BIT(1, D); });
			opCB[0x8a] = new Op("RES 1,D", delegate { D = RES(1, D); });
			opCB[0xca] = new Op("SET 1,D", delegate { D = SET(1, D); });
			opCB[0x52] = new Op("BIT 2,D", delegate { BIT(2, D); });
			opCB[0x92] = new Op("RES 2,D", delegate { D = RES(2, D); });
			opCB[0xd2] = new Op("SET 2,D", delegate { D = SET(2, D); });
			opCB[0x5a] = new Op("BIT 3,D", delegate { BIT(3, D); });
			opCB[0x9a] = new Op("RES 3,D", delegate { D = RES(3, D); });
			opCB[0xda] = new Op("SET 3,D", delegate { D = SET(3, D); });
			opCB[0x62] = new Op("BIT 4,D", delegate { BIT(4, D); });
			opCB[0xa2] = new Op("RES 4,D", delegate { D = RES(4, D); });
			opCB[0xe2] = new Op("SET 4,D", delegate { D = SET(4, D); });
			opCB[0x6a] = new Op("BIT 5,D", delegate { BIT(5, D); });
			opCB[0xaa] = new Op("RES 5,D", delegate { D = RES(5, D); });
			opCB[0xea] = new Op("SET 5,D", delegate { D = SET(5, D); });
			opCB[0x72] = new Op("BIT 6,D", delegate { BIT(6, D); });
			opCB[0xb2] = new Op("RES 6,D", delegate { D = RES(6, D); });
			opCB[0xf2] = new Op("SET 6,D", delegate { D = SET(6, D); });
			opCB[0x7a] = new Op("BIT 7,D", delegate { BIT(7, D); });
			opCB[0xba] = new Op("RES 7,D", delegate { D = RES(7, D); });
			opCB[0xfa] = new Op("SET 7,D", delegate { D = SET(7, D); });
			opCB[0x02] = new Op("RLC D", delegate { D = RLC(D); });
			opCB[0x0a] = new Op("RRC D", delegate { D = RRC(D); });
			opCB[0x12] = new Op("RL D", delegate { D = RL(D); });
			opCB[0x1a] = new Op("RR D", delegate { D = RR(D); });
			opCB[0x22] = new Op("SLA D", delegate { D = SLA(D); });
			opCB[0x2a] = new Op("SRA D", delegate { D = SRA(D); });
			opCB[0x32] = new Op("SLL D", delegate { D = SLL(D); });
			opCB[0x3a] = new Op("SRL D", delegate { D = SRL(D); });
			op[0x82] = new Op("ADD D", delegate { ADD(D); });
			op[0x8a] = new Op("ADC D", delegate { ADC(D); });
			op[0x92] = new Op("SUB D", delegate { SUB(D); });
			op[0x9a] = new Op("SBC D", delegate { SBC(D); });
			op[0xa2] = new Op("AND D", delegate { AND(D); });
			op[0xaa] = new Op("XOR D", delegate { XOR(D); });
			op[0xb2] = new Op("OR D", delegate { OR(D); });
			op[0xba] = new Op("CP D", delegate { CP(D); });
			op[0x1c] = new Op("INC E", delegate { E = INC(E); });
			op[0x1d] = new Op("DEC E", delegate { E = DEC(E); });
			op[0x1e] = new Op("LD E,n", delegate { E = n; });
			opED[0x58] = new Op("IN E,(C)", delegate { E = io.ReadByte(C); });
			opED[0x59] = new Op("OUT (C),E", delegate { OUT(C, E); });
			op[0x58] = new Op("LD E,B", delegate { E = B; });
			op[0x59] = new Op("LD E,C", delegate { E = C; });
			op[0x5a] = new Op("LD E,D", delegate { E = D; });
			op[0x5b] = new Op("LD E,E", delegate { E = E; });
			op[0x5c] = new Op("LD E,H", delegate { E = H; });
			op[0x5d] = new Op("LD E,L", delegate { E = L; });
			op[0x5e] = new Op("LD E,(HL)", delegate { E = HLAddr; });
			op[0x5f] = new Op("LD E,A", delegate { E = A; });
			op[0x7b] = new Op("LD A,E", delegate { A = E; });
			opCB[0x43] = new Op("BIT 0,E", delegate { BIT(0, E); });
			opCB[0x83] = new Op("RES 0,E", delegate { E = RES(0, E); });
			opCB[0xc3] = new Op("SET 0,E", delegate { E = SET(0, E); });
			opCB[0x4b] = new Op("BIT 1,E", delegate { BIT(1, E); });
			opCB[0x8b] = new Op("RES 1,E", delegate { E = RES(1, E); });
			opCB[0xcb] = new Op("SET 1,E", delegate { E = SET(1, E); });
			opCB[0x53] = new Op("BIT 2,E", delegate { BIT(2, E); });
			opCB[0x93] = new Op("RES 2,E", delegate { E = RES(2, E); });
			opCB[0xd3] = new Op("SET 2,E", delegate { E = SET(2, E); });
			opCB[0x5b] = new Op("BIT 3,E", delegate { BIT(3, E); });
			opCB[0x9b] = new Op("RES 3,E", delegate { E = RES(3, E); });
			opCB[0xdb] = new Op("SET 3,E", delegate { E = SET(3, E); });
			opCB[0x63] = new Op("BIT 4,E", delegate { BIT(4, E); });
			opCB[0xa3] = new Op("RES 4,E", delegate { E = RES(4, E); });
			opCB[0xe3] = new Op("SET 4,E", delegate { E = SET(4, E); });
			opCB[0x6b] = new Op("BIT 5,E", delegate { BIT(5, E); });
			opCB[0xab] = new Op("RES 5,E", delegate { E = RES(5, E); });
			opCB[0xeb] = new Op("SET 5,E", delegate { E = SET(5, E); });
			opCB[0x73] = new Op("BIT 6,E", delegate { BIT(6, E); });
			opCB[0xb3] = new Op("RES 6,E", delegate { E = RES(6, E); });
			opCB[0xf3] = new Op("SET 6,E", delegate { E = SET(6, E); });
			opCB[0x7b] = new Op("BIT 7,E", delegate { BIT(7, E); });
			opCB[0xbb] = new Op("RES 7,E", delegate { E = RES(7, E); });
			opCB[0xfb] = new Op("SET 7,E", delegate { E = SET(7, E); });
			opCB[0x03] = new Op("RLC E", delegate { E = RLC(E); });
			opCB[0x0b] = new Op("RRC E", delegate { E = RRC(E); });
			opCB[0x13] = new Op("RL E", delegate { E = RL(E); });
			opCB[0x1b] = new Op("RR E", delegate { E = RR(E); });
			opCB[0x23] = new Op("SLA E", delegate { E = SLA(E); });
			opCB[0x2b] = new Op("SRA E", delegate { E = SRA(E); });
			opCB[0x33] = new Op("SLL E", delegate { E = SLL(E); });
			opCB[0x3b] = new Op("SRL E", delegate { E = SRL(E); });
			op[0x83] = new Op("ADD E", delegate { ADD(E); });
			op[0x8b] = new Op("ADC E", delegate { ADC(E); });
			op[0x93] = new Op("SUB E", delegate { SUB(E); });
			op[0x9b] = new Op("SBC E", delegate { SBC(E); });
			op[0xa3] = new Op("AND E", delegate { AND(E); });
			op[0xab] = new Op("XOR E", delegate { XOR(E); });
			op[0xb3] = new Op("OR E", delegate { OR(E); });
			op[0xbb] = new Op("CP E", delegate { CP(E); });
			op[0x24] = new Op("INC H", delegate { H = INC(H); });
			op[0x25] = new Op("DEC H", delegate { H = DEC(H); });
			op[0x26] = new Op("LD H,n", delegate { H = n; });
			opED[0x60] = new Op("IN H,(C)", delegate { H = io.ReadByte(C); });
			opED[0x61] = new Op("OUT (C),H", delegate { OUT(C, H); });
			op[0x60] = new Op("LD H,B", delegate { H = B; });
			op[0x61] = new Op("LD H,C", delegate { H = C; });
			op[0x62] = new Op("LD H,D", delegate { H = D; });
			op[0x63] = new Op("LD H,E", delegate { H = E; });
			op[0x64] = new Op("LD H,H", delegate { H = H; });
			op[0x65] = new Op("LD H,L", delegate { H = L; });
			op[0x66] = new Op("LD H,(HL)", delegate { rHL.High = HLAddr; });
			op[0x67] = new Op("LD H,A", delegate { H = A; });
			op[0x7c] = new Op("LD A,H", delegate { A = H; });
			opCB[0x44] = new Op("BIT 0,H", delegate { BIT(0, H); });
			opCB[0x84] = new Op("RES 0,H", delegate { H = RES(0, H); });
			opCB[0xc4] = new Op("SET 0,H", delegate { H = SET(0, H); });
			opCB[0x4c] = new Op("BIT 1,H", delegate { BIT(1, H); });
			opCB[0x8c] = new Op("RES 1,H", delegate { H = RES(1, H); });
			opCB[0xcc] = new Op("SET 1,H", delegate { H = SET(1, H); });
			opCB[0x54] = new Op("BIT 2,H", delegate { BIT(2, H); });
			opCB[0x94] = new Op("RES 2,H", delegate { H = RES(2, H); });
			opCB[0xd4] = new Op("SET 2,H", delegate { H = SET(2, H); });
			opCB[0x5c] = new Op("BIT 3,H", delegate { BIT(3, H); });
			opCB[0x9c] = new Op("RES 3,H", delegate { H = RES(3, H); });
			opCB[0xdc] = new Op("SET 3,H", delegate { H = SET(3, H); });
			opCB[0x64] = new Op("BIT 4,H", delegate { BIT(4, H); });
			opCB[0xa4] = new Op("RES 4,H", delegate { H = RES(4, H); });
			opCB[0xe4] = new Op("SET 4,H", delegate { H = SET(4, H); });
			opCB[0x6c] = new Op("BIT 5,H", delegate { BIT(5, H); });
			opCB[0xac] = new Op("RES 5,H", delegate { H = RES(5, H); });
			opCB[0xec] = new Op("SET 5,H", delegate { H = SET(5, H); });
			opCB[0x74] = new Op("BIT 6,H", delegate { BIT(6, H); });
			opCB[0xb4] = new Op("RES 6,H", delegate { H = RES(6, H); });
			opCB[0xf4] = new Op("SET 6,H", delegate { H = SET(6, H); });
			opCB[0x7c] = new Op("BIT 7,H", delegate { BIT(7, H); });
			opCB[0xbc] = new Op("RES 7,H", delegate { H = RES(7, H); });
			opCB[0xfc] = new Op("SET 7,H", delegate { H = SET(7, H); });
			opCB[0x04] = new Op("RLC H", delegate { H = RLC(H); });
			opCB[0x0c] = new Op("RRC H", delegate { H = RRC(H); });
			opCB[0x14] = new Op("RL H", delegate { H = RL(H); });
			opCB[0x1c] = new Op("RR H", delegate { H = RR(H); });
			opCB[0x24] = new Op("SLA H", delegate { H = SLA(H); });
			opCB[0x2c] = new Op("SRA H", delegate { H = SRA(H); });
			opCB[0x34] = new Op("SLL H", delegate { H = SLL(H); });
			opCB[0x3c] = new Op("SRL H", delegate { H = SRL(H); });
			op[0x84] = new Op("ADD H", delegate { ADD(H); });
			op[0x8c] = new Op("ADC H", delegate { ADC(H); });
			op[0x94] = new Op("SUB H", delegate { SUB(H); });
			op[0x9c] = new Op("SBC H", delegate { SBC(H); });
			op[0xa4] = new Op("AND H", delegate { AND(H); });
			op[0xac] = new Op("XOR H", delegate { XOR(H); });
			op[0xb4] = new Op("OR H", delegate { OR(H); });
			op[0xbc] = new Op("CP H", delegate { CP(H); });
			op[0x2c] = new Op("INC L", delegate { L = INC(L); });
			op[0x2d] = new Op("DEC L", delegate { L = DEC(L); });
			op[0x2e] = new Op("LD L,n", delegate { L = n; });
			opED[0x68] = new Op("IN L,(C)", delegate { L = io.ReadByte(C); });
			opED[0x69] = new Op("OUT (C),L", delegate { OUT(C, L); });
			op[0x68] = new Op("LD L,B", delegate { L = B; });
			op[0x69] = new Op("LD L,C", delegate { L = C; });
			op[0x6a] = new Op("LD L,D", delegate { L = D; });
			op[0x6b] = new Op("LD L,E", delegate { L = E; });
			op[0x6c] = new Op("LD L,H", delegate { L = H; });
			op[0x6d] = new Op("LD L,L", delegate { L = L; });
			op[0x6e] = new Op("LD L,(HL)", delegate { rHL.Low = HLAddr; });
			op[0x6f] = new Op("LD L,A", delegate { L = A; });
			op[0x7d] = new Op("LD A,L", delegate { A = L; });
			opCB[0x45] = new Op("BIT 0,L", delegate { BIT(0, L); });
			opCB[0x85] = new Op("RES 0,L", delegate { L = RES(0, L); });
			opCB[0xc5] = new Op("SET 0,L", delegate { L = SET(0, L); });
			opCB[0x4d] = new Op("BIT 1,L", delegate { BIT(1, L); });
			opCB[0x8d] = new Op("RES 1,L", delegate { L = RES(1, L); });
			opCB[0xcd] = new Op("SET 1,L", delegate { L = SET(1, L); });
			opCB[0x55] = new Op("BIT 2,L", delegate { BIT(2, L); });
			opCB[0x95] = new Op("RES 2,L", delegate { L = RES(2, L); });
			opCB[0xd5] = new Op("SET 2,L", delegate { L = SET(2, L); });
			opCB[0x5d] = new Op("BIT 3,L", delegate { BIT(3, L); });
			opCB[0x9d] = new Op("RES 3,L", delegate { L = RES(3, L); });
			opCB[0xdd] = new Op("SET 3,L", delegate { L = SET(3, L); });
			opCB[0x65] = new Op("BIT 4,L", delegate { BIT(4, L); });
			opCB[0xa5] = new Op("RES 4,L", delegate { L = RES(4, L); });
			opCB[0xe5] = new Op("SET 4,L", delegate { L = SET(4, L); });
			opCB[0x6d] = new Op("BIT 5,L", delegate { BIT(5, L); });
			opCB[0xad] = new Op("RES 5,L", delegate { L = RES(5, L); });
			opCB[0xed] = new Op("SET 5,L", delegate { L = SET(5, L); });
			opCB[0x75] = new Op("BIT 6,L", delegate { BIT(6, L); });
			opCB[0xb5] = new Op("RES 6,L", delegate { L = RES(6, L); });
			opCB[0xf5] = new Op("SET 6,L", delegate { L = SET(6, L); });
			opCB[0x7d] = new Op("BIT 7,L", delegate { BIT(7, L); });
			opCB[0xbd] = new Op("RES 7,L", delegate { L = RES(7, L); });
			opCB[0xfd] = new Op("SET 7,L", delegate { L = SET(7, L); });
			opCB[0x05] = new Op("RLC L", delegate { L = RLC(L); });
			opCB[0x0d] = new Op("RRC L", delegate { L = RRC(L); });
			opCB[0x15] = new Op("RL L", delegate { L = RL(L); });
			opCB[0x1d] = new Op("RR L", delegate { L = RR(L); });
			opCB[0x25] = new Op("SLA L", delegate { L = SLA(L); });
			opCB[0x2d] = new Op("SRA L", delegate { L = SRA(L); });
			opCB[0x35] = new Op("SLL L", delegate { L = SLL(L); });
			opCB[0x3d] = new Op("SRL L", delegate { L = SRL(L); });
			op[0x85] = new Op("ADD L", delegate { ADD(L); });
			op[0x8d] = new Op("ADC L", delegate { ADC(L); });
			op[0x95] = new Op("SUB L", delegate { SUB(L); });
			op[0x9d] = new Op("SBC L", delegate { SBC(L); });
			op[0xa5] = new Op("AND L", delegate { AND(L); });
			op[0xad] = new Op("XOR L", delegate { XOR(L); });
			op[0xb5] = new Op("OR L", delegate { OR(L); });
			op[0xbd] = new Op("CP L", delegate { CP(L); });
			op[0x34] = new Op("INC (HL)", delegate { HLAddr = INC(HLAddr); });
			op[0x35] = new Op("DEC (HL)", delegate { HLAddr = DEC(HLAddr); });
			op[0x36] = new Op("LD (HL),n", delegate { HLAddr = n; });
			opED[0x70] = new Op("IN (HL),(C)", delegate { HLAddr = io.ReadByte(C); });
			opED[0x71] = new Op("OUT (C),(HL)", delegate { OUT(C, HLAddr); });
			op[0x70] = new Op("LD (HL),B", delegate { HLAddr = B; });
			op[0x71] = new Op("LD (HL),C", delegate { HLAddr = C; });
			op[0x72] = new Op("LD (HL),D", delegate { HLAddr = D; });
			op[0x73] = new Op("LD (HL),E", delegate { HLAddr = E; });
			op[0x74] = new Op("LD (HL),H", delegate { HLAddr = H; });
			op[0x75] = new Op("LD (HL),L", delegate { HLAddr = L; });
			op[0x76] = new Op("LD (HL),(HL)", delegate { HLAddr = HLAddr; });
			op[0x77] = new Op("LD (HL),A", delegate { HLAddr = A; });
			op[0x7e] = new Op("LD A,(HL)", delegate { A = HLAddr; });
			opCB[0x46] = new Op("BIT 0,(HL)", delegate { BIT(0, HLAddr); });
			opCB[0x86] = new Op("RES 0,(HL)", delegate { HLAddr = RES(0, HLAddr); });
			opCB[0xc6] = new Op("SET 0,(HL)", delegate { HLAddr = SET(0, HLAddr); });
			opCB[0x4e] = new Op("BIT 1,(HL)", delegate { BIT(1, HLAddr); });
			opCB[0x8e] = new Op("RES 1,(HL)", delegate { HLAddr = RES(1, HLAddr); });
			opCB[0xce] = new Op("SET 1,(HL)", delegate { HLAddr = SET(1, HLAddr); });
			opCB[0x56] = new Op("BIT 2,(HL)", delegate { BIT(2, HLAddr); });
			opCB[0x96] = new Op("RES 2,(HL)", delegate { HLAddr = RES(2, HLAddr); });
			opCB[0xd6] = new Op("SET 2,(HL)", delegate { HLAddr = SET(2, HLAddr); });
			opCB[0x5e] = new Op("BIT 3,(HL)", delegate { BIT(3, HLAddr); });
			opCB[0x9e] = new Op("RES 3,(HL)", delegate { HLAddr = RES(3, HLAddr); });
			opCB[0xde] = new Op("SET 3,(HL)", delegate { HLAddr = SET(3, HLAddr); });
			opCB[0x66] = new Op("BIT 4,(HL)", delegate { BIT(4, HLAddr); });
			opCB[0xa6] = new Op("RES 4,(HL)", delegate { HLAddr = RES(4, HLAddr); });
			opCB[0xe6] = new Op("SET 4,(HL)", delegate { HLAddr = SET(4, HLAddr); });
			opCB[0x6e] = new Op("BIT 5,(HL)", delegate { BIT(5, HLAddr); });
			opCB[0xae] = new Op("RES 5,(HL)", delegate { HLAddr = RES(5, HLAddr); });
			opCB[0xee] = new Op("SET 5,(HL)", delegate { HLAddr = SET(5, HLAddr); });
			opCB[0x76] = new Op("BIT 6,(HL)", delegate { BIT(6, HLAddr); });
			opCB[0xb6] = new Op("RES 6,(HL)", delegate { HLAddr = RES(6, HLAddr); });
			opCB[0xf6] = new Op("SET 6,(HL)", delegate { HLAddr = SET(6, HLAddr); });
			opCB[0x7e] = new Op("BIT 7,(HL)", delegate { BIT(7, HLAddr); });
			opCB[0xbe] = new Op("RES 7,(HL)", delegate { HLAddr = RES(7, HLAddr); });
			opCB[0xfe] = new Op("SET 7,(HL)", delegate { HLAddr = SET(7, HLAddr); });
			opCB[0x06] = new Op("RLC (HL)", delegate { HLAddr = RLC(HLAddr); });
			opCB[0x0e] = new Op("RRC (HL)", delegate { HLAddr = RRC(HLAddr); });
			opCB[0x16] = new Op("RL (HL)", delegate { HLAddr = RL(HLAddr); });
			opCB[0x1e] = new Op("RR (HL)", delegate { HLAddr = RR(HLAddr); });
			opCB[0x26] = new Op("SLA (HL)", delegate { HLAddr = SLA(HLAddr); });
			opCB[0x2e] = new Op("SRA (HL)", delegate { HLAddr = SRA(HLAddr); });
			opCB[0x36] = new Op("SLL (HL)", delegate { HLAddr = SLL(HLAddr); });
			opCB[0x3e] = new Op("SRL (HL)", delegate { HLAddr = SRL(HLAddr); });
			op[0x86] = new Op("ADD (HL)", delegate { ADD(HLAddr); });
			op[0x8e] = new Op("ADC (HL)", delegate { ADC(HLAddr); });
			op[0x96] = new Op("SUB (HL)", delegate { SUB(HLAddr); });
			op[0x9e] = new Op("SBC (HL)", delegate { SBC(HLAddr); });
			op[0xa6] = new Op("AND (HL)", delegate { AND(HLAddr); });
			op[0xae] = new Op("XOR (HL)", delegate { XOR(HLAddr); });
			op[0xb6] = new Op("OR (HL)", delegate { OR(HLAddr); });
			op[0xbe] = new Op("CP (HL)", delegate { CP(HLAddr); });
			op[0x3c] = new Op("INC A", delegate { A = INC(A); });
			op[0x3d] = new Op("DEC A", delegate { A = DEC(A); });
			op[0x3e] = new Op("LD A,n", delegate { A = n; });
			opED[0x78] = new Op("IN A,(C)", delegate { A = io.ReadByte(C); });
			opED[0x79] = new Op("OUT (C),A", delegate { OUT(C, A); });
			op[0x78] = new Op("LD A,B", delegate { A = B; });
			op[0x79] = new Op("LD A,C", delegate { A = C; });
			op[0x7a] = new Op("LD A,D", delegate { A = D; });
			op[0x7b] = new Op("LD A,E", delegate { A = E; });
			op[0x7c] = new Op("LD A,H", delegate { A = H; });
			op[0x7d] = new Op("LD A,L", delegate { A = L; });
			op[0x7e] = new Op("LD A,(HL)", delegate { A = HLAddr; });
			op[0x7f] = new Op("LD A,A", delegate { A = A; });
			op[0x7f] = new Op("LD A,A", delegate { A = A; });
			opCB[0x47] = new Op("BIT 0,A", delegate { BIT(0, A); });
			opCB[0x87] = new Op("RES 0,A", delegate { A = RES(0, A); });
			opCB[0xc7] = new Op("SET 0,A", delegate { A = SET(0, A); });
			opCB[0x4f] = new Op("BIT 1,A", delegate { BIT(1, A); });
			opCB[0x8f] = new Op("RES 1,A", delegate { A = RES(1, A); });
			opCB[0xcf] = new Op("SET 1,A", delegate { A = SET(1, A); });
			opCB[0x57] = new Op("BIT 2,A", delegate { BIT(2, A); });
			opCB[0x97] = new Op("RES 2,A", delegate { A = RES(2, A); });
			opCB[0xd7] = new Op("SET 2,A", delegate { A = SET(2, A); });
			opCB[0x5f] = new Op("BIT 3,A", delegate { BIT(3, A); });
			opCB[0x9f] = new Op("RES 3,A", delegate { A = RES(3, A); });
			opCB[0xdf] = new Op("SET 3,A", delegate { A = SET(3, A); });
			opCB[0x67] = new Op("BIT 4,A", delegate { BIT(4, A); });
			opCB[0xa7] = new Op("RES 4,A", delegate { A = RES(4, A); });
			opCB[0xe7] = new Op("SET 4,A", delegate { A = SET(4, A); });
			opCB[0x6f] = new Op("BIT 5,A", delegate { BIT(5, A); });
			opCB[0xaf] = new Op("RES 5,A", delegate { A = RES(5, A); });
			opCB[0xef] = new Op("SET 5,A", delegate { A = SET(5, A); });
			opCB[0x77] = new Op("BIT 6,A", delegate { BIT(6, A); });
			opCB[0xb7] = new Op("RES 6,A", delegate { A = RES(6, A); });
			opCB[0xf7] = new Op("SET 6,A", delegate { A = SET(6, A); });
			opCB[0x7f] = new Op("BIT 7,A", delegate { BIT(7, A); });
			opCB[0xbf] = new Op("RES 7,A", delegate { A = RES(7, A); });
			opCB[0xff] = new Op("SET 7,A", delegate { A = SET(7, A); });
			opCB[0x07] = new Op("RLC A", delegate { A = RLC(A); });
			opCB[0x0f] = new Op("RRC A", delegate { A = RRC(A); });
			opCB[0x17] = new Op("RL A", delegate { A = RL(A); });
			opCB[0x1f] = new Op("RR A", delegate { A = RR(A); });
			opCB[0x27] = new Op("SLA A", delegate { A = SLA(A); });
			opCB[0x2f] = new Op("SRA A", delegate { A = SRA(A); });
			opCB[0x37] = new Op("SLL A", delegate { A = SLL(A); });
			opCB[0x3f] = new Op("SRL A", delegate { A = SRL(A); });
			op[0x87] = new Op("ADD A", delegate { ADD(A); });
			op[0x8f] = new Op("ADC A", delegate { ADC(A); });
			op[0x97] = new Op("SUB A", delegate { SUB(A); });
			op[0x9f] = new Op("SBC A", delegate { SBC(A); });
			op[0xa7] = new Op("AND A", delegate { AND(A); });
			op[0xaf] = new Op("XOR A", delegate { XOR(A); });
			op[0xb7] = new Op("OR A", delegate { OR(A); });
			op[0xbf] = new Op("CP A", delegate { CP(A); });
		
			// 16-bit register operations
			op[0x01] = new Op("LD BC,nn", delegate { BC = nn; });
			op[0x03] = new Op("INC BC", delegate { BC = INC(BC); });
			op[0x09] = new Op("ADD HL,BC", delegate { HL = ADD(HL, BC); });
			op[0x0b] = new Op("DEC BC", delegate { BC = DEC(BC); });
			opED[0x42] = new Op("SBC HL,BC", delegate { HL = SBC(HL, BC); });
			opED[0x4a] = new Op("ADC HL,BC", delegate { HL = ADC(HL, BC); });
			opED[0x4b] = new Op("LD BC,(nn)", delegate { BC = Mem16(nn); });
			opED[0x43] = new Op("LD (nn),BC", delegate { Mem(nn, BC); });
			op[0x11] = new Op("LD DE,nn", delegate { DE = nn; });
			op[0x13] = new Op("INC DE", delegate { DE = INC(DE); });
			op[0x19] = new Op("ADD HL,DE", delegate { HL = ADD(HL, DE); });
			op[0x1b] = new Op("DEC DE", delegate { DE = DEC(DE); });
			opED[0x52] = new Op("SBC HL,DE", delegate { HL = SBC(HL, DE); });
			opED[0x5a] = new Op("ADC HL,DE", delegate { HL = ADC(HL, DE); });
			opED[0x5b] = new Op("LD DE,(nn)", delegate { DE = Mem16(nn); });
			opED[0x53] = new Op("LD (nn),DE", delegate { Mem(nn, DE); });
			op[0x21] = new Op("LD HL,nn", delegate { HL = nn; });
			op[0x23] = new Op("INC HL", delegate { HL = INC(HL); });
			op[0x29] = new Op("ADD HL,HL", delegate { HL = ADD(HL, HL); });
			op[0x2b] = new Op("DEC HL", delegate { HL = DEC(HL); });
			opED[0x62] = new Op("SBC HL,HL", delegate { HL = SBC(HL, HL); });
			opED[0x6a] = new Op("ADC HL,HL", delegate { HL = ADC(HL, HL); });
			opED[0x6b] = new Op("LD HL,(nn)", delegate { HL = Mem16(nn); });
			opED[0x63] = new Op("LD (nn),HL", delegate { Mem(nn, HL); });
			op[0x31] = new Op("LD SP,nn", delegate { SP = nn; });
			op[0x33] = new Op("INC SP", delegate { SP = INC(SP); });
			op[0x39] = new Op("ADD HL,SP", delegate { HL = ADD(HL, SP); });
			op[0x3b] = new Op("DEC SP", delegate { SP = DEC(SP); });
			opED[0x72] = new Op("SBC HL,SP", delegate { HL = SBC(HL, SP); });
			opED[0x7a] = new Op("ADC HL,SP", delegate { HL = ADC(HL, SP); });
			opED[0x7b] = new Op("LD SP,(nn)", delegate { SP = Mem16(nn); });
			opED[0x73] = new Op("LD (nn),SP", delegate { Mem(nn, SP); });

			// Restart operations
			op[0xc7] = new Op("RST 00H", delegate { RST(0x00); });
			op[0xcf] = new Op("RST 08H", delegate { RST(0x08); });
			op[0xd7] = new Op("RST 10H", delegate { RST(0x10); });
			op[0xdf] = new Op("RST 18H", delegate { RST(0x18); });
			op[0xe7] = new Op("RST 20H", delegate { RST(0x20); });
			op[0xef] = new Op("RST 28H", delegate { RST(0x28); });
			op[0xf7] = new Op("RST 30H", delegate { RST(0x30); });
			op[0xff] = new Op("RST 38H", delegate { RST(0x38); });
			
			// Conditional flow operations
			op[0xc0] = new Op("RET NZ", delegate { RET(TestNZ); });
			op[0xc2] = new Op("JP NZ,nn", delegate { JP(TestNZ, nn); });
			op[0xc4] = new Op("CALL NZ,nn", delegate { CALL(TestNZ, nn); });
			op[0x20] = new Op("JR NZ,e", delegate { JR(TestNZ, GetE()); });
			op[0xc8] = new Op("RET Z", delegate { RET(TestZ); });
			op[0xca] = new Op("JP Z,nn", delegate { JP(TestZ, nn); });
			op[0xcc] = new Op("CALL Z,nn", delegate { CALL(TestZ, nn); });
			op[0x28] = new Op("JR Z,e", delegate { JR(TestZ, GetE()); });
			op[0xd0] = new Op("RET NC", delegate { RET(TestNC); });
			op[0xd2] = new Op("JP NC,nn", delegate { JP(TestNC, nn); });
			op[0xd4] = new Op("CALL NC,nn", delegate { CALL(TestNC, nn); });
			op[0x30] = new Op("JR NC,e", delegate { JR(TestNC, GetE()); });
			op[0xd8] = new Op("RET C", delegate { RET(TestC); });
			op[0xda] = new Op("JP C,nn", delegate { JP(TestC, nn); });
			op[0xdc] = new Op("CALL C,nn", delegate { CALL(TestC, nn); });
			op[0x38] = new Op("JR C,e", delegate { JR(TestC, GetE()); });
			op[0xe0] = new Op("RET PO", delegate { RET(TestPO); });
			op[0xe2] = new Op("JP PO,nn", delegate { JP(TestPO, nn); });
			op[0xe4] = new Op("CALL PO,nn", delegate { CALL(TestPO, nn); });
			op[0xe8] = new Op("RET PE", delegate { RET(TestPE); });
			op[0xea] = new Op("JP PE,nn", delegate { JP(TestPE, nn); });
			op[0xec] = new Op("CALL PE,nn", delegate { CALL(TestPE, nn); });
			op[0xf0] = new Op("RET P", delegate { RET(TestP); });
			op[0xf2] = new Op("JP P,nn", delegate { JP(TestP, nn); });
			op[0xf4] = new Op("CALL P,nn", delegate { CALL(TestP, nn); });
			op[0xf8] = new Op("RET M", delegate { RET(TestM); });
			op[0xfa] = new Op("JP M,nn", delegate { JP(TestM, nn); });
			op[0xfc] = new Op("CALL M,nn", delegate { CALL(TestM, nn); });
			
			// Stack operations
			op[0xc1] = new Op("POP BC", delegate { BC = POP(); });
			op[0xc5] = new Op("PUSH BC", delegate { PUSH(BC); });
			op[0xd1] = new Op("POP DE", delegate { DE = POP(); });
			op[0xd5] = new Op("PUSH DE", delegate { PUSH(DE); });
			op[0xe1] = new Op("POP HL", delegate { HL = POP(); });
			op[0xe5] = new Op("PUSH HL", delegate { PUSH(HL); });
			op[0xf1] = new Op("POP AF", delegate { AF = POP(); });
			op[0xf5] = new Op("PUSH AF", delegate { PUSH(AF); });
		}
	}
}