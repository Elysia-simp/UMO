// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class NGIOPBLNBDJ : Table {
  public static NGIOPBLNBDJ GetRootAsNGIOPBLNBDJ(ByteBuffer _bb) { return GetRootAsNGIOPBLNBDJ(_bb, new NGIOPBLNBDJ()); }
  public static NGIOPBLNBDJ GetRootAsNGIOPBLNBDJ(ByteBuffer _bb, NGIOPBLNBDJ obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public NGIOPBLNBDJ __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public BAODEIILGPO GetJEILJOANFFE(int j) { return GetJEILJOANFFE(new BAODEIILGPO(), j); }
  public BAODEIILGPO GetJEILJOANFFE(BAODEIILGPO obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int JEILJOANFFELength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<NGIOPBLNBDJ> CreateNGIOPBLNBDJ(FlatBufferBuilder builder,
      VectorOffset JEILJOANFFEOffset = default(VectorOffset)) {
    builder.StartObject(1);
    NGIOPBLNBDJ.AddJEILJOANFFE(builder, JEILJOANFFEOffset);
    return NGIOPBLNBDJ.EndNGIOPBLNBDJ(builder);
  }

  public static void StartNGIOPBLNBDJ(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddJEILJOANFFE(FlatBufferBuilder builder, VectorOffset JEILJOANFFEOffset) { builder.AddOffset(0, JEILJOANFFEOffset.Value, 0); }
  public static VectorOffset CreateJEILJOANFFEVector(FlatBufferBuilder builder, Offset<BAODEIILGPO>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartJEILJOANFFEVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<NGIOPBLNBDJ> EndNGIOPBLNBDJ(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<NGIOPBLNBDJ>(o);
  }
};

