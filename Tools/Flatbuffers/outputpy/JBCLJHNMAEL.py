# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class JBCLJHNMAEL(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsJBCLJHNMAEL(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = JBCLJHNMAEL()
        x.Init(buf, n + offset)
        return x

    # JBCLJHNMAEL
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # JBCLJHNMAEL
    def BBPHAPFBFHK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # JBCLJHNMAEL
    def CFLMCGOJJJD(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # JBCLJHNMAEL
    def HHFEPINGMEI(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # JBCLJHNMAEL
    def NJLJEKDBPCH(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # JBCLJHNMAEL
    def MAOAGDBDBIB(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(12))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

def JBCLJHNMAELStart(builder): builder.StartObject(5)
def JBCLJHNMAELAddBBPHAPFBFHK(builder, BBPHAPFBFHK): builder.PrependUint32Slot(0, BBPHAPFBFHK, 0)
def JBCLJHNMAELAddCFLMCGOJJJD(builder, CFLMCGOJJJD): builder.PrependUint32Slot(1, CFLMCGOJJJD, 0)
def JBCLJHNMAELAddHHFEPINGMEI(builder, HHFEPINGMEI): builder.PrependUint32Slot(2, HHFEPINGMEI, 0)
def JBCLJHNMAELAddNJLJEKDBPCH(builder, NJLJEKDBPCH): builder.PrependUint32Slot(3, NJLJEKDBPCH, 0)
def JBCLJHNMAELAddMAOAGDBDBIB(builder, MAOAGDBDBIB): builder.PrependUint32Slot(4, MAOAGDBDBIB, 0)
def JBCLJHNMAELEnd(builder): return builder.EndObject()
