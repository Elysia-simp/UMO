// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class DFOHOJKKKDJ : Table {
  public static DFOHOJKKKDJ GetRootAsDFOHOJKKKDJ(ByteBuffer _bb) { return GetRootAsDFOHOJKKKDJ(_bb, new DFOHOJKKKDJ()); }
  public static DFOHOJKKKDJ GetRootAsDFOHOJKKKDJ(ByteBuffer _bb, DFOHOJKKKDJ obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public DFOHOJKKKDJ __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public uint BBPHAPFBFHK { get { int o = __offset(4); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint CFLMCGOJJJD { get { int o = __offset(6); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint MJGMLHPCJKL { get { int o = __offset(8); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint KEJFLGLANOM { get { int o = __offset(10); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public int GetKKIOBDILLGC(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int KKIOBDILLGCLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public ArraySegment<byte>? GetKKIOBDILLGCBytes() { return __vector_as_arraysegment(12); }
  public uint GCPGKNHOELA { get { int o = __offset(14); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint OINHNODKGMO { get { int o = __offset(16); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint PDMFOEDKBPM { get { int o = __offset(18); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint DKLGCNIKBNO { get { int o = __offset(20); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint CAOMFEHHCJO { get { int o = __offset(22); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint NGHNHBKONEK { get { int o = __offset(24); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint AAEFDGPJPDH { get { int o = __offset(26); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint BPOBCDFADPN { get { int o = __offset(28); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint BDPKAIDKLBB { get { int o = __offset(30); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint PKAOKEACOEE { get { int o = __offset(32); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }

  public static Offset<DFOHOJKKKDJ> CreateDFOHOJKKKDJ(FlatBufferBuilder builder,
      uint BBPHAPFBFHK = 0,
      uint CFLMCGOJJJD = 0,
      uint MJGMLHPCJKL = 0,
      uint KEJFLGLANOM = 0,
      VectorOffset KKIOBDILLGCOffset = default(VectorOffset),
      uint GCPGKNHOELA = 0,
      uint OINHNODKGMO = 0,
      uint PDMFOEDKBPM = 0,
      uint DKLGCNIKBNO = 0,
      uint CAOMFEHHCJO = 0,
      uint NGHNHBKONEK = 0,
      uint AAEFDGPJPDH = 0,
      uint BPOBCDFADPN = 0,
      uint BDPKAIDKLBB = 0,
      uint PKAOKEACOEE = 0) {
    builder.StartObject(15);
    DFOHOJKKKDJ.AddPKAOKEACOEE(builder, PKAOKEACOEE);
    DFOHOJKKKDJ.AddBDPKAIDKLBB(builder, BDPKAIDKLBB);
    DFOHOJKKKDJ.AddBPOBCDFADPN(builder, BPOBCDFADPN);
    DFOHOJKKKDJ.AddAAEFDGPJPDH(builder, AAEFDGPJPDH);
    DFOHOJKKKDJ.AddNGHNHBKONEK(builder, NGHNHBKONEK);
    DFOHOJKKKDJ.AddCAOMFEHHCJO(builder, CAOMFEHHCJO);
    DFOHOJKKKDJ.AddDKLGCNIKBNO(builder, DKLGCNIKBNO);
    DFOHOJKKKDJ.AddPDMFOEDKBPM(builder, PDMFOEDKBPM);
    DFOHOJKKKDJ.AddOINHNODKGMO(builder, OINHNODKGMO);
    DFOHOJKKKDJ.AddGCPGKNHOELA(builder, GCPGKNHOELA);
    DFOHOJKKKDJ.AddKKIOBDILLGC(builder, KKIOBDILLGCOffset);
    DFOHOJKKKDJ.AddKEJFLGLANOM(builder, KEJFLGLANOM);
    DFOHOJKKKDJ.AddMJGMLHPCJKL(builder, MJGMLHPCJKL);
    DFOHOJKKKDJ.AddCFLMCGOJJJD(builder, CFLMCGOJJJD);
    DFOHOJKKKDJ.AddBBPHAPFBFHK(builder, BBPHAPFBFHK);
    return DFOHOJKKKDJ.EndDFOHOJKKKDJ(builder);
  }

  public static void StartDFOHOJKKKDJ(FlatBufferBuilder builder) { builder.StartObject(15); }
  public static void AddBBPHAPFBFHK(FlatBufferBuilder builder, uint BBPHAPFBFHK) { builder.AddUint(0, BBPHAPFBFHK, 0); }
  public static void AddCFLMCGOJJJD(FlatBufferBuilder builder, uint CFLMCGOJJJD) { builder.AddUint(1, CFLMCGOJJJD, 0); }
  public static void AddMJGMLHPCJKL(FlatBufferBuilder builder, uint MJGMLHPCJKL) { builder.AddUint(2, MJGMLHPCJKL, 0); }
  public static void AddKEJFLGLANOM(FlatBufferBuilder builder, uint KEJFLGLANOM) { builder.AddUint(3, KEJFLGLANOM, 0); }
  public static void AddKKIOBDILLGC(FlatBufferBuilder builder, VectorOffset KKIOBDILLGCOffset) { builder.AddOffset(4, KKIOBDILLGCOffset.Value, 0); }
  public static VectorOffset CreateKKIOBDILLGCVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartKKIOBDILLGCVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddGCPGKNHOELA(FlatBufferBuilder builder, uint GCPGKNHOELA) { builder.AddUint(5, GCPGKNHOELA, 0); }
  public static void AddOINHNODKGMO(FlatBufferBuilder builder, uint OINHNODKGMO) { builder.AddUint(6, OINHNODKGMO, 0); }
  public static void AddPDMFOEDKBPM(FlatBufferBuilder builder, uint PDMFOEDKBPM) { builder.AddUint(7, PDMFOEDKBPM, 0); }
  public static void AddDKLGCNIKBNO(FlatBufferBuilder builder, uint DKLGCNIKBNO) { builder.AddUint(8, DKLGCNIKBNO, 0); }
  public static void AddCAOMFEHHCJO(FlatBufferBuilder builder, uint CAOMFEHHCJO) { builder.AddUint(9, CAOMFEHHCJO, 0); }
  public static void AddNGHNHBKONEK(FlatBufferBuilder builder, uint NGHNHBKONEK) { builder.AddUint(10, NGHNHBKONEK, 0); }
  public static void AddAAEFDGPJPDH(FlatBufferBuilder builder, uint AAEFDGPJPDH) { builder.AddUint(11, AAEFDGPJPDH, 0); }
  public static void AddBPOBCDFADPN(FlatBufferBuilder builder, uint BPOBCDFADPN) { builder.AddUint(12, BPOBCDFADPN, 0); }
  public static void AddBDPKAIDKLBB(FlatBufferBuilder builder, uint BDPKAIDKLBB) { builder.AddUint(13, BDPKAIDKLBB, 0); }
  public static void AddPKAOKEACOEE(FlatBufferBuilder builder, uint PKAOKEACOEE) { builder.AddUint(14, PKAOKEACOEE, 0); }
  public static Offset<DFOHOJKKKDJ> EndDFOHOJKKKDJ(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<DFOHOJKKKDJ>(o);
  }
};
