﻿using Monero.Client.Network;
using Monero.Client.Utilities;
using System.Text.Json.Serialization;

namespace Monero.Client.Wallet.POD.Responses
{
    internal class FundTransferResponse : RpcResponse
    {
        [JsonPropertyName("address")]
        public FundTransfer Result { get; set; }
    }

    public class FundTransfer
    {
        [JsonPropertyName("amount")]
        public ulong Amount { get; set; }
        [JsonPropertyName("fee")]
        public ulong Fee { get; set; }
        [JsonPropertyName("multisig_txset")]
        public string MultiSigTxSet { get; set; }
        [JsonPropertyName("tx_blob")]
        public string TransactionBlob { get; set; }
        [JsonPropertyName("tx_hash")]
        public string TransactionHash { get; set; }
        [JsonPropertyName("tx_key")]
        public string TransactionKey { get; set; }
        [JsonPropertyName("tx_metadata")]
        public string TransactionMetadata { get; set; }
        [JsonPropertyName("unsigned_txset")]
        public string UnsignedTxSet { get; set; }
        [JsonPropertyName("weight")]
        public ulong Weight { get; set; }
        public override string ToString()
        {
            return $"Sent {PriceUtilities.PiconeroToMonero(Amount).ToString(PriceFormat.MoneroPrecision)} with a fee of {PriceUtilities.PiconeroToMonero(Fee).ToString(PriceFormat.MoneroPrecision)} [{TransactionHash}]";
        }
    }
}