# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class ELJJEFEIEIK(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsELJJEFEIEIK(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = ELJJEFEIEIK()
        x.Init(buf, n + offset)
        return x

    # ELJJEFEIEIK
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # ELJJEFEIEIK
    def BBPHAPFBFHK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # ELJJEFEIEIK
    def CFLMCGOJJJD(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # ELJJEFEIEIK
    def NJLJEKDBPCH(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # ELJJEFEIEIK
    def MAOAGDBDBIB(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

def ELJJEFEIEIKStart(builder): builder.StartObject(4)
def ELJJEFEIEIKAddBBPHAPFBFHK(builder, BBPHAPFBFHK): builder.PrependUint32Slot(0, BBPHAPFBFHK, 0)
def ELJJEFEIEIKAddCFLMCGOJJJD(builder, CFLMCGOJJJD): builder.PrependUint32Slot(1, CFLMCGOJJJD, 0)
def ELJJEFEIEIKAddNJLJEKDBPCH(builder, NJLJEKDBPCH): builder.PrependUint32Slot(2, NJLJEKDBPCH, 0)
def ELJJEFEIEIKAddMAOAGDBDBIB(builder, MAOAGDBDBIB): builder.PrependUint32Slot(3, MAOAGDBDBIB, 0)
def ELJJEFEIEIKEnd(builder): return builder.EndObject()