# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class PBJDMDHLPIP(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsPBJDMDHLPIP(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = PBJDMDHLPIP()
        x.Init(buf, n + offset)
        return x

    # PBJDMDHLPIP
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # PBJDMDHLPIP
    def AGOIMGHMGOH(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.String(o + self._tab.Pos)
        return ""

    # PBJDMDHLPIP
    def KJFEBMBHKOC(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.String(o + self._tab.Pos)
        return ""

def PBJDMDHLPIPStart(builder): builder.StartObject(2)
def PBJDMDHLPIPAddAGOIMGHMGOH(builder, AGOIMGHMGOH): builder.PrependUOffsetTRelativeSlot(0, flatbuffers.number_types.UOffsetTFlags.py_type(AGOIMGHMGOH), 0)
def PBJDMDHLPIPAddKJFEBMBHKOC(builder, KJFEBMBHKOC): builder.PrependUOffsetTRelativeSlot(1, flatbuffers.number_types.UOffsetTFlags.py_type(KJFEBMBHKOC), 0)
def PBJDMDHLPIPEnd(builder): return builder.EndObject()