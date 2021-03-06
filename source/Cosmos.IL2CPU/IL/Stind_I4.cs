using System;


namespace Cosmos.IL2CPU.X86.IL
{
  [Cosmos.IL2CPU.OpCode(ILOpCode.Code.Stind_I4)]
  public class Stind_I4 : ILOp
  {
    public Stind_I4(XSharp.Assembler.Assembler aAsmblr)
        : base(aAsmblr)
    {
    }

    public override void Execute(_MethodInfo aMethod, ILOpCode aOpCode)
    {
      Stind_I.Assemble(Assembler, 4, DebugEnabled);
    }
  }
}
