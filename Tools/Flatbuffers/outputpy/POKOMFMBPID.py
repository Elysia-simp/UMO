# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class POKOMFMBPID(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsPOKOMFMBPID(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = POKOMFMBPID()
        x.Init(buf, n + offset)
        return x

    # POKOMFMBPID
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # POKOMFMBPID
    def BBPHAPFBFHK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # POKOMFMBPID
    def OFMGALJGDAO(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # POKOMFMBPID
    def CFLMCGOJJJD(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # POKOMFMBPID
    def BJGOGMAOOOF(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # POKOMFMBPID
    def NJLJEKDBPCH(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(12))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # POKOMFMBPID
    def MAOAGDBDBIB(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(14))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # POKOMFMBPID
    def HAEMDABJFJF(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(16))
        if o != 0:
            return self._tab.String(o + self._tab.Pos)
        return ""

    # POKOMFMBPID
    def OAHOHJALFMC(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(18))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

def POKOMFMBPIDStart(builder): builder.StartObject(8)
def POKOMFMBPIDAddBBPHAPFBFHK(builder, BBPHAPFBFHK): builder.PrependInt32Slot(0, BBPHAPFBFHK, 0)
def POKOMFMBPIDAddOFMGALJGDAO(builder, OFMGALJGDAO): builder.PrependInt32Slot(1, OFMGALJGDAO, 0)
def POKOMFMBPIDAddCFLMCGOJJJD(builder, CFLMCGOJJJD): builder.PrependUint32Slot(2, CFLMCGOJJJD, 0)
def POKOMFMBPIDAddBJGOGMAOOOF(builder, BJGOGMAOOOF): builder.PrependInt32Slot(3, BJGOGMAOOOF, 0)
def POKOMFMBPIDAddNJLJEKDBPCH(builder, NJLJEKDBPCH): builder.PrependUint32Slot(4, NJLJEKDBPCH, 0)
def POKOMFMBPIDAddMAOAGDBDBIB(builder, MAOAGDBDBIB): builder.PrependUint32Slot(5, MAOAGDBDBIB, 0)
def POKOMFMBPIDAddHAEMDABJFJF(builder, HAEMDABJFJF): builder.PrependUOffsetTRelativeSlot(6, flatbuffers.number_types.UOffsetTFlags.py_type(HAEMDABJFJF), 0)
def POKOMFMBPIDAddOAHOHJALFMC(builder, OAHOHJALFMC): builder.PrependInt32Slot(7, OAHOHJALFMC, 0)
def POKOMFMBPIDEnd(builder): return builder.EndObject()