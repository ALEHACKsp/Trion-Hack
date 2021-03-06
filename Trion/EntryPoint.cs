﻿using Trion.SDK.Dumpers;
using Trion.SDK.Interfaces;
using Trion.SDK.Interfaces.Engine;

namespace Trion
{
    internal unsafe struct EntryPoint
    {
        public static int DLLMain()
        {
            Interface.Panel.Hook(41, Hooks.PaintTraverseDelegate);
            Interface.ClientMode.Hook(24, Hooks.CreateMoveDelegate);
            Interface.GameEventManager.Hook(9, Hooks.FireEventClientSideDelegate);
            Interface.BaseClientDLL.Hook(37, Hooks.FrameStageNotifyDelegate);
            Interface.ClientMode.Hook(44, Hooks.DoPostScreenEffectsDelegate);
            Interface.NetVar.HookProp("DT_BaseViewModel", "m_nSequence", Hooks.SetViewModelSequenceDelegate, ref Interface.NetVar.SequencePtr);
            Interface.Surface.Hook(67, Hooks.LockCursorDelegate);
            return 0;
        }
    }
}