// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class LPLDAEJONGA : Table {
  public static LPLDAEJONGA GetRootAsLPLDAEJONGA(ByteBuffer _bb) { return GetRootAsLPLDAEJONGA(_bb, new LPLDAEJONGA()); }
  public static LPLDAEJONGA GetRootAsLPLDAEJONGA(ByteBuffer _bb, LPLDAEJONGA obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public LPLDAEJONGA __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public GCFDBLLEKED GetDGCEKGHCAKJ(int j) { return GetDGCEKGHCAKJ(new GCFDBLLEKED(), j); }
  public GCFDBLLEKED GetDGCEKGHCAKJ(GCFDBLLEKED obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int DGCEKGHCAKJLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }
  public FOLCOOKNNKO GetFJNMMFMGMKK(int j) { return GetFJNMMFMGMKK(new FOLCOOKNNKO(), j); }
  public FOLCOOKNNKO GetFJNMMFMGMKK(FOLCOOKNNKO obj, int j) { int o = __offset(6); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int FJNMMFMGMKKLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<LPLDAEJONGA> CreateLPLDAEJONGA(FlatBufferBuilder builder,
      VectorOffset DGCEKGHCAKJOffset = default(VectorOffset),
      VectorOffset FJNMMFMGMKKOffset = default(VectorOffset)) {
    builder.StartObject(2);
    LPLDAEJONGA.AddFJNMMFMGMKK(builder, FJNMMFMGMKKOffset);
    LPLDAEJONGA.AddDGCEKGHCAKJ(builder, DGCEKGHCAKJOffset);
    return LPLDAEJONGA.EndLPLDAEJONGA(builder);
  }

  public static void StartLPLDAEJONGA(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddDGCEKGHCAKJ(FlatBufferBuilder builder, VectorOffset DGCEKGHCAKJOffset) { builder.AddOffset(0, DGCEKGHCAKJOffset.Value, 0); }
  public static VectorOffset CreateDGCEKGHCAKJVector(FlatBufferBuilder builder, Offset<GCFDBLLEKED>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartDGCEKGHCAKJVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddFJNMMFMGMKK(FlatBufferBuilder builder, VectorOffset FJNMMFMGMKKOffset) { builder.AddOffset(1, FJNMMFMGMKKOffset.Value, 0); }
  public static VectorOffset CreateFJNMMFMGMKKVector(FlatBufferBuilder builder, Offset<FOLCOOKNNKO>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartFJNMMFMGMKKVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<LPLDAEJONGA> EndLPLDAEJONGA(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<LPLDAEJONGA>(o);
  }
};
