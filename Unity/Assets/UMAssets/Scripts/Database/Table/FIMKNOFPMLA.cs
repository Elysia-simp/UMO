// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class FIMKNOFPMLA : Table {
  public static FIMKNOFPMLA GetRootAsFIMKNOFPMLA(ByteBuffer _bb) { return GetRootAsFIMKNOFPMLA(_bb, new FIMKNOFPMLA()); }
  public static FIMKNOFPMLA GetRootAsFIMKNOFPMLA(ByteBuffer _bb, FIMKNOFPMLA obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FIMKNOFPMLA __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public string IIDCFMHCPLJ { get { int o = __offset(4); return o != 0 ? __string(o + bb_pos) : null; } }
  public ArraySegment<byte>? GetIIDCFMHCPLJBytes() { return __vector_as_arraysegment(4); }
  public int PAPMBEBHHIG { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FIMKNOFPMLA> CreateFIMKNOFPMLA(FlatBufferBuilder builder,
      StringOffset IIDCFMHCPLJOffset = default(StringOffset),
      int PAPMBEBHHIG = 0) {
    builder.StartObject(2);
    FIMKNOFPMLA.AddPAPMBEBHHIG(builder, PAPMBEBHHIG);
    FIMKNOFPMLA.AddIIDCFMHCPLJ(builder, IIDCFMHCPLJOffset);
    return FIMKNOFPMLA.EndFIMKNOFPMLA(builder);
  }

  public static void StartFIMKNOFPMLA(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddIIDCFMHCPLJ(FlatBufferBuilder builder, StringOffset IIDCFMHCPLJOffset) { builder.AddOffset(0, IIDCFMHCPLJOffset.Value, 0); }
  public static void AddPAPMBEBHHIG(FlatBufferBuilder builder, int PAPMBEBHHIG) { builder.AddInt(1, PAPMBEBHHIG, 0); }
  public static Offset<FIMKNOFPMLA> EndFIMKNOFPMLA(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FIMKNOFPMLA>(o);
  }
};

