// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class JPNGMOOGNIA : Table {
  public static JPNGMOOGNIA GetRootAsJPNGMOOGNIA(ByteBuffer _bb) { return GetRootAsJPNGMOOGNIA(_bb, new JPNGMOOGNIA()); }
  public static JPNGMOOGNIA GetRootAsJPNGMOOGNIA(ByteBuffer _bb, JPNGMOOGNIA obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public JPNGMOOGNIA __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public JBAKGMLAGMJ GetGHBONFLCMKC(int j) { return GetGHBONFLCMKC(new JBAKGMLAGMJ(), j); }
  public JBAKGMLAGMJ GetGHBONFLCMKC(JBAKGMLAGMJ obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int GHBONFLCMKCLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<JPNGMOOGNIA> CreateJPNGMOOGNIA(FlatBufferBuilder builder,
      VectorOffset GHBONFLCMKCOffset = default(VectorOffset)) {
    builder.StartObject(1);
    JPNGMOOGNIA.AddGHBONFLCMKC(builder, GHBONFLCMKCOffset);
    return JPNGMOOGNIA.EndJPNGMOOGNIA(builder);
  }

  public static void StartJPNGMOOGNIA(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddGHBONFLCMKC(FlatBufferBuilder builder, VectorOffset GHBONFLCMKCOffset) { builder.AddOffset(0, GHBONFLCMKCOffset.Value, 0); }
  public static VectorOffset CreateGHBONFLCMKCVector(FlatBufferBuilder builder, Offset<JBAKGMLAGMJ>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartGHBONFLCMKCVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<JPNGMOOGNIA> EndJPNGMOOGNIA(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<JPNGMOOGNIA>(o);
  }
};

