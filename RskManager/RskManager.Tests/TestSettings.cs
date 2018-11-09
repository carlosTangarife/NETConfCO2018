﻿using System;
namespace RskManager.Tests
{
    public class TestSettings
    {
        public static string CowAccountAddress = "0xcd2a3d9f938e13cd947ec05abc7fe734df8dd826";
        public static string CowAvailableBalance = "0xc9f2c9cd04674edea40000000";
        public static string NewAccountAddress = "";
        public static string NewAccountPrivateKey = "";
        public static string GasAmountToSend = "0x30000000";
        public static string GasPrice = "0x0";
        public static string TxValue = "0x0";
        public static string ContractByteCode = "608060405234801561001057600080fd5b506040805180820190915260138082527f48656c6c6f202e4e455420436f6e6620434f210000000000000000000000000060209092019182526100559160009161005b565b506100f6565b828054600181600116156101000203166002900490600052602060002090601f016020900481019282601f1061009c57805160ff19168380011785556100c9565b828001600101855582156100c9579182015b828111156100c95782518255916020019190600101906100ae565b506100d59291506100d9565b5090565b6100f391905b808211156100d557600081556001016100df565b90565b6102c0806101056000396000f30060806040526004361061004b5763ffffffff7c0100000000000000000000000000000000000000000000000000000000600035041663a41368628114610050578063fe50cc72146100bd575b600080fd5b34801561005c57600080fd5b506040805160206004803580820135601f81018490048402850184019095528484526100a99436949293602493928401919081908401838280828437509497506101479650505050505050565b604080519115158252519081900360200190f35b3480156100c957600080fd5b506100d2610165565b6040805160208082528351818301528351919283929083019185019080838360005b8381101561010c5781810151838201526020016100f4565b50505050905090810190601f1680156101395780820380516001836020036101000a031916815260200191505b509250505060405180910390f35b805160009061015c90829060208501906101fc565b50600192915050565b60008054604080516020601f60026000196101006001881615020190951694909404938401819004810282018101909252828152606093909290918301828280156101f15780601f106101c6576101008083540402835291602001916101f1565b820191906000526020600020905b8154815290600101906020018083116101d457829003601f168201915b505050505090505b90565b828054600181600116156101000203166002900490600052602060002090601f016020900481019282601f1061023d57805160ff191683800117855561026a565b8280016001018555821561026a579182015b8281111561026a57825182559160200191906001019061024f565b5061027692915061027a565b5090565b6101f991905b8082111561027657600081556001016102805600a165627a7a72305820de3eab3d7e1ce0b1283d8248fee1a4196fd3e9d45f4eac5190e69538912de0e80029";
        public static string ContractAbi = "[{\"constant\":false,\"inputs\":[{\"name\":\"_newGreeting\",\"type\":\"string\"}],\"name\":\"setGreeting\",\"outputs\":[{\"name\":\"success\",\"type\":\"bool\"}],\"payable\":false,\"stateMutability\":\"nonpayable\",\"type\":\"function\"},{\"constant\":true,\"inputs\":[],\"name\":\"getGreeting\",\"outputs\":[{\"name\":\"\",\"type\":\"string\"}],\"payable\":false,\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[],\"payable\":false,\"stateMutability\":\"nonpayable\",\"type\":\"constructor\"}]";
        public static string ContractAddress = "";
        public static string ContractMethod = "getGreeting";
        public static string ContractMethodResponse = "Hello .NET Conf CO!";
    }
}
