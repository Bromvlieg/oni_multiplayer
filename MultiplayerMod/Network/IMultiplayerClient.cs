﻿using System;
using MultiplayerMod.Multiplayer;
using MultiplayerMod.Network.Events;

namespace MultiplayerMod.Network;

public interface IMultiplayerClient {
    MultiplayerClientState State { get; }
    IPlayer Player { get; }

    void Connect(IMultiplayerEndpoint endpoint);
    void Disconnect();

    void Send(IMultiplayerCommand command, MultiplayerCommandOptions options = MultiplayerCommandOptions.None);

    event EventHandler<ClientStateChangedEventArgs> StateChanged;
    event EventHandler<CommandReceivedEventArgs> CommandReceived;
}
