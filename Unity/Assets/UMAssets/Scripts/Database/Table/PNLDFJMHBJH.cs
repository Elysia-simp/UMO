// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class PNLDFJMHBJH : Table {
  public static PNLDFJMHBJH GetRootAsPNLDFJMHBJH(ByteBuffer _bb) { return GetRootAsPNLDFJMHBJH(_bb, new PNLDFJMHBJH()); }
  public static PNLDFJMHBJH GetRootAsPNLDFJMHBJH(ByteBuffer _bb, PNLDFJMHBJH obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public PNLDFJMHBJH __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public uint BBPHAPFBFHK { get { int o = __offset(4); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public string IIDCFMHCPLJ { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public ArraySegment<byte>? GetIIDCFMHCPLJBytes() { return __vector_as_arraysegment(6); }
  public string HAEJDOGGKPC { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public ArraySegment<byte>? GetHAEJDOGGKPCBytes() { return __vector_as_arraysegment(8); }
  public uint GetNHNLGCMFBNC(int j) { int o = __offset(10); return o != 0 ? bb.GetUint(__vector(o) + j * 4) : (uint)0; }
  public int NHNLGCMFBNCLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public ArraySegment<byte>? GetNHNLGCMFBNCBytes() { return __vector_as_arraysegment(10); }

  public static Offset<PNLDFJMHBJH> CreatePNLDFJMHBJH(FlatBufferBuilder builder,
      uint BBPHAPFBFHK = 0,
      StringOffset IIDCFMHCPLJOffset = default(StringOffset),
      StringOffset HAEJDOGGKPCOffset = default(StringOffset),
      VectorOffset NHNLGCMFBNCOffset = default(VectorOffset)) {
    builder.StartObject(4);
    PNLDFJMHBJH.AddNHNLGCMFBNC(builder, NHNLGCMFBNCOffset);
    PNLDFJMHBJH.AddHAEJDOGGKPC(builder, HAEJDOGGKPCOffset);
    PNLDFJMHBJH.AddIIDCFMHCPLJ(builder, IIDCFMHCPLJOffset);
    PNLDFJMHBJH.AddBBPHAPFBFHK(builder, BBPHAPFBFHK);
    return PNLDFJMHBJH.EndPNLDFJMHBJH(builder);
  }

  public static void StartPNLDFJMHBJH(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddBBPHAPFBFHK(FlatBufferBuilder builder, uint BBPHAPFBFHK) { builder.AddUint(0, BBPHAPFBFHK, 0); }
  public static void AddIIDCFMHCPLJ(FlatBufferBuilder builder, StringOffset IIDCFMHCPLJOffset) { builder.AddOffset(1, IIDCFMHCPLJOffset.Value, 0); }
  public static void AddHAEJDOGGKPC(FlatBufferBuilder builder, StringOffset HAEJDOGGKPCOffset) { builder.AddOffset(2, HAEJDOGGKPCOffset.Value, 0); }
  public static void AddNHNLGCMFBNC(FlatBufferBuilder builder, VectorOffset NHNLGCMFBNCOffset) { builder.AddOffset(3, NHNLGCMFBNCOffset.Value, 0); }
  public static VectorOffset CreateNHNLGCMFBNCVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  public static void StartNHNLGCMFBNCVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<PNLDFJMHBJH> EndPNLDFJMHBJH(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<PNLDFJMHBJH>(o);
  }
};

