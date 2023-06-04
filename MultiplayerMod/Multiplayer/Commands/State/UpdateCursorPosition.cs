using System;
using MultiplayerMod.Multiplayer.State;
using UnityEngine;

namespace MultiplayerMod.Multiplayer.Commands.State;

[Serializable]
public class UpdateCursorPosition : IMultiplayerCommand {

    private IPlayer player;
    private Vector2 position;
    private long hzTicks;

    public UpdateCursorPosition(IPlayer player, Vector2 position, long hzTicks) {
        this.player = player;
        this.position = position;
        this.hzTicks = hzTicks;
    }

    public void Execute() {
        MultiplayerState.Shared.Players.TryGetValue(player, out var state);
        if (state == null)
            return;

        // update old to previouse new
        state.CursorPosition = state.CursorPositionNew;

        // set data to be able to smooth out cursor movement
        state.CursorPositionNewTime = System.DateTime.Now;
        state.CursorPositionNewHzTicks = hzTicks;
        state.CursorPositionNew = position;
    }

}
