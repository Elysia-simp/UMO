// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class IGPIHCHKGPE : Table {
  public static IGPIHCHKGPE GetRootAsIGPIHCHKGPE(ByteBuffer _bb) { return GetRootAsIGPIHCHKGPE(_bb, new IGPIHCHKGPE()); }
  public static IGPIHCHKGPE GetRootAsIGPIHCHKGPE(ByteBuffer _bb, IGPIHCHKGPE obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public IGPIHCHKGPE __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public uint BBPHAPFBFHK { get { int o = __offset(4); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint CFLMCGOJJJD { get { int o = __offset(6); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint LPJPOOHJKAE { get { int o = __offset(8); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint AEAKMMJLLDK { get { int o = __offset(10); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public string NNKLANONDOM { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public ArraySegment<byte>? GetNNKLANONDOMBytes() { return __vector_as_arraysegment(12); }
  public string JGAGKFPAAIB { get { int o = __offset(14); return o != 0 ? __string(o + bb_pos) : null; } }
  public ArraySegment<byte>? GetJGAGKFPAAIBBytes() { return __vector_as_arraysegment(14); }
  public uint NMGIFIOPMIJ { get { int o = __offset(16); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint NFPKGHADCCP { get { int o = __offset(18); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint PJCPCILBICH { get { int o = __offset(20); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint GAHFANCNFIH { get { int o = __offset(22); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint ANOHJLDOAAK { get { int o = __offset(24); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint GJJPLLHMMAF { get { int o = __offset(26); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint AJHANMOKKDF { get { int o = __offset(28); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint PBAJJGLCCDO { get { int o = __offset(30); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint MPMOLHBIKKG { get { int o = __offset(32); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint ENECIEOGIJC { get { int o = __offset(34); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint MBBJMJAAODG { get { int o = __offset(36); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint IMCFOKIBEMC { get { int o = __offset(38); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint OADMJNEOKLC { get { int o = __offset(40); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint EGCKDOIIACL { get { int o = __offset(42); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint GPBKFHCJEPD { get { int o = __offset(44); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint EBBBDFADIPN { get { int o = __offset(46); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint GLIIHLOLPEF { get { int o = __offset(48); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint KMEODDMBHHE { get { int o = __offset(50); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }

  public static Offset<IGPIHCHKGPE> CreateIGPIHCHKGPE(FlatBufferBuilder builder,
      uint BBPHAPFBFHK = 0,
      uint CFLMCGOJJJD = 0,
      uint LPJPOOHJKAE = 0,
      uint AEAKMMJLLDK = 0,
      StringOffset NNKLANONDOMOffset = default(StringOffset),
      StringOffset JGAGKFPAAIBOffset = default(StringOffset),
      uint NMGIFIOPMIJ = 0,
      uint NFPKGHADCCP = 0,
      uint PJCPCILBICH = 0,
      uint GAHFANCNFIH = 0,
      uint ANOHJLDOAAK = 0,
      uint GJJPLLHMMAF = 0,
      uint AJHANMOKKDF = 0,
      uint PBAJJGLCCDO = 0,
      uint MPMOLHBIKKG = 0,
      uint ENECIEOGIJC = 0,
      uint MBBJMJAAODG = 0,
      uint IMCFOKIBEMC = 0,
      uint OADMJNEOKLC = 0,
      uint EGCKDOIIACL = 0,
      uint GPBKFHCJEPD = 0,
      uint EBBBDFADIPN = 0,
      uint GLIIHLOLPEF = 0,
      uint KMEODDMBHHE = 0) {
    builder.StartObject(24);
    IGPIHCHKGPE.AddKMEODDMBHHE(builder, KMEODDMBHHE);
    IGPIHCHKGPE.AddGLIIHLOLPEF(builder, GLIIHLOLPEF);
    IGPIHCHKGPE.AddEBBBDFADIPN(builder, EBBBDFADIPN);
    IGPIHCHKGPE.AddGPBKFHCJEPD(builder, GPBKFHCJEPD);
    IGPIHCHKGPE.AddEGCKDOIIACL(builder, EGCKDOIIACL);
    IGPIHCHKGPE.AddOADMJNEOKLC(builder, OADMJNEOKLC);
    IGPIHCHKGPE.AddIMCFOKIBEMC(builder, IMCFOKIBEMC);
    IGPIHCHKGPE.AddMBBJMJAAODG(builder, MBBJMJAAODG);
    IGPIHCHKGPE.AddENECIEOGIJC(builder, ENECIEOGIJC);
    IGPIHCHKGPE.AddMPMOLHBIKKG(builder, MPMOLHBIKKG);
    IGPIHCHKGPE.AddPBAJJGLCCDO(builder, PBAJJGLCCDO);
    IGPIHCHKGPE.AddAJHANMOKKDF(builder, AJHANMOKKDF);
    IGPIHCHKGPE.AddGJJPLLHMMAF(builder, GJJPLLHMMAF);
    IGPIHCHKGPE.AddANOHJLDOAAK(builder, ANOHJLDOAAK);
    IGPIHCHKGPE.AddGAHFANCNFIH(builder, GAHFANCNFIH);
    IGPIHCHKGPE.AddPJCPCILBICH(builder, PJCPCILBICH);
    IGPIHCHKGPE.AddNFPKGHADCCP(builder, NFPKGHADCCP);
    IGPIHCHKGPE.AddNMGIFIOPMIJ(builder, NMGIFIOPMIJ);
    IGPIHCHKGPE.AddJGAGKFPAAIB(builder, JGAGKFPAAIBOffset);
    IGPIHCHKGPE.AddNNKLANONDOM(builder, NNKLANONDOMOffset);
    IGPIHCHKGPE.AddAEAKMMJLLDK(builder, AEAKMMJLLDK);
    IGPIHCHKGPE.AddLPJPOOHJKAE(builder, LPJPOOHJKAE);
    IGPIHCHKGPE.AddCFLMCGOJJJD(builder, CFLMCGOJJJD);
    IGPIHCHKGPE.AddBBPHAPFBFHK(builder, BBPHAPFBFHK);
    return IGPIHCHKGPE.EndIGPIHCHKGPE(builder);
  }

  public static void StartIGPIHCHKGPE(FlatBufferBuilder builder) { builder.StartObject(24); }
  public static void AddBBPHAPFBFHK(FlatBufferBuilder builder, uint BBPHAPFBFHK) { builder.AddUint(0, BBPHAPFBFHK, 0); }
  public static void AddCFLMCGOJJJD(FlatBufferBuilder builder, uint CFLMCGOJJJD) { builder.AddUint(1, CFLMCGOJJJD, 0); }
  public static void AddLPJPOOHJKAE(FlatBufferBuilder builder, uint LPJPOOHJKAE) { builder.AddUint(2, LPJPOOHJKAE, 0); }
  public static void AddAEAKMMJLLDK(FlatBufferBuilder builder, uint AEAKMMJLLDK) { builder.AddUint(3, AEAKMMJLLDK, 0); }
  public static void AddNNKLANONDOM(FlatBufferBuilder builder, StringOffset NNKLANONDOMOffset) { builder.AddOffset(4, NNKLANONDOMOffset.Value, 0); }
  public static void AddJGAGKFPAAIB(FlatBufferBuilder builder, StringOffset JGAGKFPAAIBOffset) { builder.AddOffset(5, JGAGKFPAAIBOffset.Value, 0); }
  public static void AddNMGIFIOPMIJ(FlatBufferBuilder builder, uint NMGIFIOPMIJ) { builder.AddUint(6, NMGIFIOPMIJ, 0); }
  public static void AddNFPKGHADCCP(FlatBufferBuilder builder, uint NFPKGHADCCP) { builder.AddUint(7, NFPKGHADCCP, 0); }
  public static void AddPJCPCILBICH(FlatBufferBuilder builder, uint PJCPCILBICH) { builder.AddUint(8, PJCPCILBICH, 0); }
  public static void AddGAHFANCNFIH(FlatBufferBuilder builder, uint GAHFANCNFIH) { builder.AddUint(9, GAHFANCNFIH, 0); }
  public static void AddANOHJLDOAAK(FlatBufferBuilder builder, uint ANOHJLDOAAK) { builder.AddUint(10, ANOHJLDOAAK, 0); }
  public static void AddGJJPLLHMMAF(FlatBufferBuilder builder, uint GJJPLLHMMAF) { builder.AddUint(11, GJJPLLHMMAF, 0); }
  public static void AddAJHANMOKKDF(FlatBufferBuilder builder, uint AJHANMOKKDF) { builder.AddUint(12, AJHANMOKKDF, 0); }
  public static void AddPBAJJGLCCDO(FlatBufferBuilder builder, uint PBAJJGLCCDO) { builder.AddUint(13, PBAJJGLCCDO, 0); }
  public static void AddMPMOLHBIKKG(FlatBufferBuilder builder, uint MPMOLHBIKKG) { builder.AddUint(14, MPMOLHBIKKG, 0); }
  public static void AddENECIEOGIJC(FlatBufferBuilder builder, uint ENECIEOGIJC) { builder.AddUint(15, ENECIEOGIJC, 0); }
  public static void AddMBBJMJAAODG(FlatBufferBuilder builder, uint MBBJMJAAODG) { builder.AddUint(16, MBBJMJAAODG, 0); }
  public static void AddIMCFOKIBEMC(FlatBufferBuilder builder, uint IMCFOKIBEMC) { builder.AddUint(17, IMCFOKIBEMC, 0); }
  public static void AddOADMJNEOKLC(FlatBufferBuilder builder, uint OADMJNEOKLC) { builder.AddUint(18, OADMJNEOKLC, 0); }
  public static void AddEGCKDOIIACL(FlatBufferBuilder builder, uint EGCKDOIIACL) { builder.AddUint(19, EGCKDOIIACL, 0); }
  public static void AddGPBKFHCJEPD(FlatBufferBuilder builder, uint GPBKFHCJEPD) { builder.AddUint(20, GPBKFHCJEPD, 0); }
  public static void AddEBBBDFADIPN(FlatBufferBuilder builder, uint EBBBDFADIPN) { builder.AddUint(21, EBBBDFADIPN, 0); }
  public static void AddGLIIHLOLPEF(FlatBufferBuilder builder, uint GLIIHLOLPEF) { builder.AddUint(22, GLIIHLOLPEF, 0); }
  public static void AddKMEODDMBHHE(FlatBufferBuilder builder, uint KMEODDMBHHE) { builder.AddUint(23, KMEODDMBHHE, 0); }
  public static Offset<IGPIHCHKGPE> EndIGPIHCHKGPE(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<IGPIHCHKGPE>(o);
  }
};

