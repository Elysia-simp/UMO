// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class EMBHNHBBIEE : Table {
  public static EMBHNHBBIEE GetRootAsEMBHNHBBIEE(ByteBuffer _bb) { return GetRootAsEMBHNHBBIEE(_bb, new EMBHNHBBIEE()); }
  public static EMBHNHBBIEE GetRootAsEMBHNHBBIEE(ByteBuffer _bb, EMBHNHBBIEE obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public EMBHNHBBIEE __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public uint BBPHAPFBFHK { get { int o = __offset(4); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint HJNPKHJJDBB { get { int o = __offset(6); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public int GetLEFPIGNDJNC(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int LEFPIGNDJNCLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public ArraySegment<byte>? GetLEFPIGNDJNCBytes() { return __vector_as_arraysegment(8); }
  public uint GetBNCIPLKECMC(int j) { int o = __offset(10); return o != 0 ? bb.GetUint(__vector(o) + j * 4) : (uint)0; }
  public int BNCIPLKECMCLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public ArraySegment<byte>? GetBNCIPLKECMCBytes() { return __vector_as_arraysegment(10); }
  public uint GetOOJBHHPJONJ(int j) { int o = __offset(12); return o != 0 ? bb.GetUint(__vector(o) + j * 4) : (uint)0; }
  public int OOJBHHPJONJLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public ArraySegment<byte>? GetOOJBHHPJONJBytes() { return __vector_as_arraysegment(12); }
  public int ALPALMJMJJK { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public uint GetPODPGCKCBEO(int j) { int o = __offset(16); return o != 0 ? bb.GetUint(__vector(o) + j * 4) : (uint)0; }
  public int PODPGCKCBEOLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public ArraySegment<byte>? GetPODPGCKCBEOBytes() { return __vector_as_arraysegment(16); }

  public static Offset<EMBHNHBBIEE> CreateEMBHNHBBIEE(FlatBufferBuilder builder,
      uint BBPHAPFBFHK = 0,
      uint HJNPKHJJDBB = 0,
      VectorOffset LEFPIGNDJNCOffset = default(VectorOffset),
      VectorOffset BNCIPLKECMCOffset = default(VectorOffset),
      VectorOffset OOJBHHPJONJOffset = default(VectorOffset),
      int ALPALMJMJJK = 0,
      VectorOffset PODPGCKCBEOOffset = default(VectorOffset)) {
    builder.StartObject(7);
    EMBHNHBBIEE.AddPODPGCKCBEO(builder, PODPGCKCBEOOffset);
    EMBHNHBBIEE.AddALPALMJMJJK(builder, ALPALMJMJJK);
    EMBHNHBBIEE.AddOOJBHHPJONJ(builder, OOJBHHPJONJOffset);
    EMBHNHBBIEE.AddBNCIPLKECMC(builder, BNCIPLKECMCOffset);
    EMBHNHBBIEE.AddLEFPIGNDJNC(builder, LEFPIGNDJNCOffset);
    EMBHNHBBIEE.AddHJNPKHJJDBB(builder, HJNPKHJJDBB);
    EMBHNHBBIEE.AddBBPHAPFBFHK(builder, BBPHAPFBFHK);
    return EMBHNHBBIEE.EndEMBHNHBBIEE(builder);
  }

  public static void StartEMBHNHBBIEE(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddBBPHAPFBFHK(FlatBufferBuilder builder, uint BBPHAPFBFHK) { builder.AddUint(0, BBPHAPFBFHK, 0); }
  public static void AddHJNPKHJJDBB(FlatBufferBuilder builder, uint HJNPKHJJDBB) { builder.AddUint(1, HJNPKHJJDBB, 0); }
  public static void AddLEFPIGNDJNC(FlatBufferBuilder builder, VectorOffset LEFPIGNDJNCOffset) { builder.AddOffset(2, LEFPIGNDJNCOffset.Value, 0); }
  public static VectorOffset CreateLEFPIGNDJNCVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartLEFPIGNDJNCVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBNCIPLKECMC(FlatBufferBuilder builder, VectorOffset BNCIPLKECMCOffset) { builder.AddOffset(3, BNCIPLKECMCOffset.Value, 0); }
  public static VectorOffset CreateBNCIPLKECMCVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  public static void StartBNCIPLKECMCVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddOOJBHHPJONJ(FlatBufferBuilder builder, VectorOffset OOJBHHPJONJOffset) { builder.AddOffset(4, OOJBHHPJONJOffset.Value, 0); }
  public static VectorOffset CreateOOJBHHPJONJVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  public static void StartOOJBHHPJONJVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddALPALMJMJJK(FlatBufferBuilder builder, int ALPALMJMJJK) { builder.AddInt(5, ALPALMJMJJK, 0); }
  public static void AddPODPGCKCBEO(FlatBufferBuilder builder, VectorOffset PODPGCKCBEOOffset) { builder.AddOffset(6, PODPGCKCBEOOffset.Value, 0); }
  public static VectorOffset CreatePODPGCKCBEOVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  public static void StartPODPGCKCBEOVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<EMBHNHBBIEE> EndEMBHNHBBIEE(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<EMBHNHBBIEE>(o);
  }
};

