using System;
using UnityEngine;

namespace MultiplayerMod.Multiplayer.State;

[Serializable]
public class PlayerSharedState {
    public IPlayer Player { get; }
    public Vector2 CursorPosition { get; set; }
    public Vector2 CursorPositionNew { get; set; }
    public System.DateTime CursorPositionNewTime { get; set; }
    public long CursorPositionNewHzTicks { get; set; }

    public PlayerSharedState(IPlayer player) {
        Player = player;
    }
}
