# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class EHHOIAKGOEI(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsEHHOIAKGOEI(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = EHHOIAKGOEI()
        x.Init(buf, n + offset)
        return x

    # EHHOIAKGOEI
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # EHHOIAKGOEI
    def BBPHAPFBFHK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # EHHOIAKGOEI
    def EJFPCDPDIHP(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # EHHOIAKGOEI
    def GEJGMBBCFEE(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

def EHHOIAKGOEIStart(builder): builder.StartObject(3)
def EHHOIAKGOEIAddBBPHAPFBFHK(builder, BBPHAPFBFHK): builder.PrependInt32Slot(0, BBPHAPFBFHK, 0)
def EHHOIAKGOEIAddEJFPCDPDIHP(builder, EJFPCDPDIHP): builder.PrependInt32Slot(1, EJFPCDPDIHP, 0)
def EHHOIAKGOEIAddGEJGMBBCFEE(builder, GEJGMBBCFEE): builder.PrependInt32Slot(2, GEJGMBBCFEE, 0)
def EHHOIAKGOEIEnd(builder): return builder.EndObject()