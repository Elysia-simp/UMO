// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class PCDBMJGPDFN : Table {
  public static PCDBMJGPDFN GetRootAsPCDBMJGPDFN(ByteBuffer _bb) { return GetRootAsPCDBMJGPDFN(_bb, new PCDBMJGPDFN()); }
  public static PCDBMJGPDFN GetRootAsPCDBMJGPDFN(ByteBuffer _bb, PCDBMJGPDFN obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public PCDBMJGPDFN __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public uint LNHODOPAJIL { get { int o = __offset(4); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint LHMHAFHMNFF { get { int o = __offset(6); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint CLEEFGNMCEL { get { int o = __offset(8); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint CIJLLHJEANC { get { int o = __offset(10); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }

  public static Offset<PCDBMJGPDFN> CreatePCDBMJGPDFN(FlatBufferBuilder builder,
      uint LNHODOPAJIL = 0,
      uint LHMHAFHMNFF = 0,
      uint CLEEFGNMCEL = 0,
      uint CIJLLHJEANC = 0) {
    builder.StartObject(4);
    PCDBMJGPDFN.AddCIJLLHJEANC(builder, CIJLLHJEANC);
    PCDBMJGPDFN.AddCLEEFGNMCEL(builder, CLEEFGNMCEL);
    PCDBMJGPDFN.AddLHMHAFHMNFF(builder, LHMHAFHMNFF);
    PCDBMJGPDFN.AddLNHODOPAJIL(builder, LNHODOPAJIL);
    return PCDBMJGPDFN.EndPCDBMJGPDFN(builder);
  }

  public static void StartPCDBMJGPDFN(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddLNHODOPAJIL(FlatBufferBuilder builder, uint LNHODOPAJIL) { builder.AddUint(0, LNHODOPAJIL, 0); }
  public static void AddLHMHAFHMNFF(FlatBufferBuilder builder, uint LHMHAFHMNFF) { builder.AddUint(1, LHMHAFHMNFF, 0); }
  public static void AddCLEEFGNMCEL(FlatBufferBuilder builder, uint CLEEFGNMCEL) { builder.AddUint(2, CLEEFGNMCEL, 0); }
  public static void AddCIJLLHJEANC(FlatBufferBuilder builder, uint CIJLLHJEANC) { builder.AddUint(3, CIJLLHJEANC, 0); }
  public static Offset<PCDBMJGPDFN> EndPCDBMJGPDFN(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<PCDBMJGPDFN>(o);
  }
};
