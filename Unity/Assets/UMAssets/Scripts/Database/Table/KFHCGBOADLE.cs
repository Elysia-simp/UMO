// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class KFHCGBOADLE : Table {
  public static KFHCGBOADLE GetRootAsKFHCGBOADLE(ByteBuffer _bb) { return GetRootAsKFHCGBOADLE(_bb, new KFHCGBOADLE()); }
  public static KFHCGBOADLE GetRootAsKFHCGBOADLE(ByteBuffer _bb, KFHCGBOADLE obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public KFHCGBOADLE __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public ODDOBDBBJAB GetBHHFEPOGOIG(int j) { return GetBHHFEPOGOIG(new ODDOBDBBJAB(), j); }
  public ODDOBDBBJAB GetBHHFEPOGOIG(ODDOBDBBJAB obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int BHHFEPOGOIGLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }
  public DNHKFIKECGD GetCMAPNGGMDOI(int j) { return GetCMAPNGGMDOI(new DNHKFIKECGD(), j); }
  public DNHKFIKECGD GetCMAPNGGMDOI(DNHKFIKECGD obj, int j) { int o = __offset(6); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int CMAPNGGMDOILength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public PCDBMJGPDFN GetILBKJACHOHM(int j) { return GetILBKJACHOHM(new PCDBMJGPDFN(), j); }
  public PCDBMJGPDFN GetILBKJACHOHM(PCDBMJGPDFN obj, int j) { int o = __offset(8); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ILBKJACHOHMLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<KFHCGBOADLE> CreateKFHCGBOADLE(FlatBufferBuilder builder,
      VectorOffset BHHFEPOGOIGOffset = default(VectorOffset),
      VectorOffset CMAPNGGMDOIOffset = default(VectorOffset),
      VectorOffset ILBKJACHOHMOffset = default(VectorOffset)) {
    builder.StartObject(3);
    KFHCGBOADLE.AddILBKJACHOHM(builder, ILBKJACHOHMOffset);
    KFHCGBOADLE.AddCMAPNGGMDOI(builder, CMAPNGGMDOIOffset);
    KFHCGBOADLE.AddBHHFEPOGOIG(builder, BHHFEPOGOIGOffset);
    return KFHCGBOADLE.EndKFHCGBOADLE(builder);
  }

  public static void StartKFHCGBOADLE(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddBHHFEPOGOIG(FlatBufferBuilder builder, VectorOffset BHHFEPOGOIGOffset) { builder.AddOffset(0, BHHFEPOGOIGOffset.Value, 0); }
  public static VectorOffset CreateBHHFEPOGOIGVector(FlatBufferBuilder builder, Offset<ODDOBDBBJAB>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartBHHFEPOGOIGVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCMAPNGGMDOI(FlatBufferBuilder builder, VectorOffset CMAPNGGMDOIOffset) { builder.AddOffset(1, CMAPNGGMDOIOffset.Value, 0); }
  public static VectorOffset CreateCMAPNGGMDOIVector(FlatBufferBuilder builder, Offset<DNHKFIKECGD>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartCMAPNGGMDOIVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddILBKJACHOHM(FlatBufferBuilder builder, VectorOffset ILBKJACHOHMOffset) { builder.AddOffset(2, ILBKJACHOHMOffset.Value, 0); }
  public static VectorOffset CreateILBKJACHOHMVector(FlatBufferBuilder builder, Offset<PCDBMJGPDFN>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartILBKJACHOHMVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<KFHCGBOADLE> EndKFHCGBOADLE(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<KFHCGBOADLE>(o);
  }
};

