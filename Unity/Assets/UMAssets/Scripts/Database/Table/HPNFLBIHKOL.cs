// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class HPNFLBIHKOL : Table {
  public static HPNFLBIHKOL GetRootAsHPNFLBIHKOL(ByteBuffer _bb) { return GetRootAsHPNFLBIHKOL(_bb, new HPNFLBIHKOL()); }
  public static HPNFLBIHKOL GetRootAsHPNFLBIHKOL(ByteBuffer _bb, HPNFLBIHKOL obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public HPNFLBIHKOL __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int BBPHAPFBFHK { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int DLPCOLDNAKE { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GKLKKGBNGFP { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public uint BPGDKJJFAJC { get { int o = __offset(10); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }

  public static Offset<HPNFLBIHKOL> CreateHPNFLBIHKOL(FlatBufferBuilder builder,
      int BBPHAPFBFHK = 0,
      int DLPCOLDNAKE = 0,
      int GKLKKGBNGFP = 0,
      uint BPGDKJJFAJC = 0) {
    builder.StartObject(4);
    HPNFLBIHKOL.AddBPGDKJJFAJC(builder, BPGDKJJFAJC);
    HPNFLBIHKOL.AddGKLKKGBNGFP(builder, GKLKKGBNGFP);
    HPNFLBIHKOL.AddDLPCOLDNAKE(builder, DLPCOLDNAKE);
    HPNFLBIHKOL.AddBBPHAPFBFHK(builder, BBPHAPFBFHK);
    return HPNFLBIHKOL.EndHPNFLBIHKOL(builder);
  }

  public static void StartHPNFLBIHKOL(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddBBPHAPFBFHK(FlatBufferBuilder builder, int BBPHAPFBFHK) { builder.AddInt(0, BBPHAPFBFHK, 0); }
  public static void AddDLPCOLDNAKE(FlatBufferBuilder builder, int DLPCOLDNAKE) { builder.AddInt(1, DLPCOLDNAKE, 0); }
  public static void AddGKLKKGBNGFP(FlatBufferBuilder builder, int GKLKKGBNGFP) { builder.AddInt(2, GKLKKGBNGFP, 0); }
  public static void AddBPGDKJJFAJC(FlatBufferBuilder builder, uint BPGDKJJFAJC) { builder.AddUint(3, BPGDKJJFAJC, 0); }
  public static Offset<HPNFLBIHKOL> EndHPNFLBIHKOL(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<HPNFLBIHKOL>(o);
  }
};

