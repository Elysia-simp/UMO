# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class AMCNEEPKDOP(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsAMCNEEPKDOP(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = AMCNEEPKDOP()
        x.Init(buf, n + offset)
        return x

    # AMCNEEPKDOP
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # AMCNEEPKDOP
    def AGOIMGHMGOH(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.String(o + self._tab.Pos)
        return ""

    # AMCNEEPKDOP
    def KJFEBMBHKOC(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

def AMCNEEPKDOPStart(builder): builder.StartObject(2)
def AMCNEEPKDOPAddAGOIMGHMGOH(builder, AGOIMGHMGOH): builder.PrependUOffsetTRelativeSlot(0, flatbuffers.number_types.UOffsetTFlags.py_type(AGOIMGHMGOH), 0)
def AMCNEEPKDOPAddKJFEBMBHKOC(builder, KJFEBMBHKOC): builder.PrependInt32Slot(1, KJFEBMBHKOC, 0)
def AMCNEEPKDOPEnd(builder): return builder.EndObject()