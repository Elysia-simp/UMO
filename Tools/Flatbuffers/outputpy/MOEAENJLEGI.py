# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class MOEAENJLEGI(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsMOEAENJLEGI(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = MOEAENJLEGI()
        x.Init(buf, n + offset)
        return x

    # MOEAENJLEGI
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # MOEAENJLEGI
    def BBPHAPFBFHK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # MOEAENJLEGI
    def CFLMCGOJJJD(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # MOEAENJLEGI
    def IAPFGOHKAGE(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # MOEAENJLEGI
    def NJLJEKDBPCH(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # MOEAENJLEGI
    def MAOAGDBDBIB(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(12))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

def MOEAENJLEGIStart(builder): builder.StartObject(5)
def MOEAENJLEGIAddBBPHAPFBFHK(builder, BBPHAPFBFHK): builder.PrependUint32Slot(0, BBPHAPFBFHK, 0)
def MOEAENJLEGIAddCFLMCGOJJJD(builder, CFLMCGOJJJD): builder.PrependUint32Slot(1, CFLMCGOJJJD, 0)
def MOEAENJLEGIAddIAPFGOHKAGE(builder, IAPFGOHKAGE): builder.PrependUint32Slot(2, IAPFGOHKAGE, 0)
def MOEAENJLEGIAddNJLJEKDBPCH(builder, NJLJEKDBPCH): builder.PrependInt32Slot(3, NJLJEKDBPCH, 0)
def MOEAENJLEGIAddMAOAGDBDBIB(builder, MAOAGDBDBIB): builder.PrependInt32Slot(4, MAOAGDBDBIB, 0)
def MOEAENJLEGIEnd(builder): return builder.EndObject()