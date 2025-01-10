﻿using Newtonsoft.Json;

namespace BTCPayServer.Plugins.Monero.RPC.Models;

public class TransferRequest
{
    [JsonProperty("destinations")] public TransferDestination[] Destinations { get; set; }
}
public class TransferResponse
{
    [JsonProperty("tx_hash")] public string TransactionHash { get; set; }
}