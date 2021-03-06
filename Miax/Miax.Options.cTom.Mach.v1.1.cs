namespace Miax.Options.cTom.Mach.v1.1 {

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Active On Miax Values
    /// </summary>
    public enum ActiveOnMiax : byte {
        Active = (byte)'A',
        Inactive = (byte)'I',
    };


    /// <summary>
    ///  Bid Condition Values
    /// </summary>
    public enum BidCondition : byte {
        Regular = (byte)'A',
        TradingHalt = (byte)'T',
        Wide = (byte)'W',
        SimpleAuction = (byte)'S',
        ComplexAuction = (byte)'C',
        SimpleMarketProtection = (byte)'M',
        LegMarketProtection = (byte)'L',
    };


    /// <summary>
    ///  Bid Reserved 2
    /// </summary>
    public unsafe struct BidReserved2 {
        public const int Size = 2;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Bid Reserved 4
    /// </summary>
    public unsafe struct BidReserved4 {
        public const int Size = 4;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Call Or Put Values
    /// </summary>
    public enum CallOrPut : byte {
        Call = (byte)'C',
        Put = (byte)'P',
    };


    /// <summary>
    ///  Closing Time
    /// </summary>
    public unsafe struct ClosingTime {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Compact Bid Price
    /// </summary>
    public struct CompactBidPrice {
        public short Raw;
    };


    /// <summary>
    ///  Compact Bid Size
    /// </summary>
    public unsafe struct CompactBidSize {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Compact Offer Price
    /// </summary>
    public struct CompactOfferPrice {
        public short Raw;
    };


    /// <summary>
    ///  Compact Offer Size
    /// </summary>
    public unsafe struct CompactOfferSize {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Compact Price
    /// </summary>
    public struct CompactPrice {
        public short Raw;
    };


    /// <summary>
    ///  Compact Size
    /// </summary>
    public unsafe struct CompactSize {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Event Reason Values
    /// </summary>
    public enum EventReason : byte {
        Automatic = (byte)'A',
        Manual = (byte)'M',
    };


    /// <summary>
    ///  Expected Event Time Nano Seconds Part
    /// </summary>
    public unsafe struct ExpectedEventTimeNanoSecondsPart {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Expiration Date
    /// </summary>
    public unsafe struct ExpirationDate {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leg Ratio Qty
    /// </summary>
    public unsafe struct LegRatioQty {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leg Side Values
    /// </summary>
    public enum LegSide : byte {
        Bid = B,
        Ask = A,
    };


    /// <summary>
    ///  Liquidity Acceptance Increment Indicator Values
    /// </summary>
    public enum LiquidityAcceptanceIncrementIndicator : byte {
        Penny = (byte)'P',
        Nickel = (byte)'N',
        Dime = (byte)'D',
    };


    /// <summary>
    ///  Long Term Option Values
    /// </summary>
    public enum LongTermOption : byte {
        Yes = (byte)'Y',
        No = (byte)'N',
    };


    /// <summary>
    ///  Message Type Values
    /// </summary>
    public enum MessageType : byte {
        SystemTimeMessage = (byte)'1',
        SeriesUpdate = (byte)'P',
        ComplexStrategyDefinitionMessage = (byte)'C',
        SystemStateMessage = (byte)'S',
        ComplexTopOfMarketBidCompactMessage = (byte)'b',
        ComplexTopOfMarketOfferCompactMessage = (byte)'o',
        WideComplexTopOfMarketBidMessage = (byte)'e',
        WideComplexTopOfMarketOfferMessage = (byte)'f',
        ComplexDoubleSidedTopOfMarketCompactMessage = (byte)'m',
        WideComplexDoubleSidedTopOfMarketMessage = (byte)'w',
        StrategyTradeMessage = (byte)'t',
        UnderlyingTradingStatusMessage = (byte)'H',
    };


    /// <summary>
    ///  Miax Bbo Posting Increment Indicator Values
    /// </summary>
    public enum MiaxBboPostingIncrementIndicator : byte {
        Penny = (byte)'P',
        Nickel = (byte)'N',
        Dime = (byte)'D',
    };


    /// <summary>
    ///  Net Price
    /// </summary>
    public struct NetPrice {
        public long Raw;
    };


    /// <summary>
    ///  Notification Time
    /// </summary>
    public unsafe struct NotificationTime {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Number Of Legs
    /// </summary>
    public unsafe struct NumberOfLegs {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Offer Condition Values
    /// </summary>
    public enum OfferCondition : byte {
        Regular = (byte)'A',
        TradingHalt = (byte)'T',
        Wide = (byte)'W',
        SimpleAuction = (byte)'S',
        ComplexAuction = (byte)'C',
        SimpleMarketProtection = (byte)'M',
        LegMarketProtection = (byte)'L',
    };


    /// <summary>
    ///  Offer Reserved 2
    /// </summary>
    public unsafe struct OfferReserved2 {
        public const int Size = 2;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Offer Reserved 4
    /// </summary>
    public unsafe struct OfferReserved4 {
        public const int Size = 4;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Opening Time
    /// </summary>
    public unsafe struct OpeningTime {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Opening Underlying Market Code Values
    /// </summary>
    public enum OpeningUnderlyingMarketCode : byte {
        NyseAmex = (byte)'A',
        NasdaqOmxBx = (byte)'B',
        Nse = (byte)'C',
        FinraAdf = (byte)'D',
        MarketIndependent = (byte)'E',
        Ise = (byte)'I',
        Edga = (byte)'J',
        Edgx = (byte)'K',
        Cse = (byte)'M',
        NyseEuronext = (byte)'N',
        NyseArca = (byte)'P',
        NasdaqOmxUtp = (byte)'Q',
        NasdaqOmxCta = (byte)'T',
        Iex = (byte)'V',
        NasdaqOmxPhlx = (byte)'X',
        BatsY = (byte)'Y',
        Bats = (byte)'Z',
    };


    /// <summary>
    ///  Packet Length
    /// </summary>
    public unsafe struct PacketLength {
        public const int Size = 2;

        public short Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Packet Type Values
    /// </summary>
    public enum PacketType : byte {
        Heartbeat = 0,
        StartOfSession = 1,
        EndOfSession = 2,
        ApplicationMessage = 3,
    };


    /// <summary>
    ///  Priority Quote Width
    /// </summary>
    public unsafe struct PriorityQuoteWidth {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Product Add Update Time
    /// </summary>
    public unsafe struct ProductAddUpdateTime {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Product Id
    /// </summary>
    public unsafe struct ProductId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Reserved 1
    /// </summary>
    public unsafe struct Reserved1 {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved 10
    /// </summary>
    public unsafe struct Reserved10 {
        public const int Size = 10;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved 16
    /// </summary>
    public unsafe struct Reserved16 {
        public const int Size = 16;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved 2
    /// </summary>
    public unsafe struct Reserved2 {
        public const int Size = 2;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved 4
    /// </summary>
    public unsafe struct Reserved4 {
        public const int Size = 4;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved 8
    /// </summary>
    public unsafe struct Reserved8 {
        public const int Size = 8;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved8
    /// </summary>
    public unsafe struct Reserved8 {
        public const int Size = 8;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Restricted Option Values
    /// </summary>
    public enum RestrictedOption : byte {
        Yes = (byte)'Y',
        No = (byte)'N',
    };


    /// <summary>
    ///  Seconds Part
    /// </summary>
    public unsafe struct SecondsPart {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Symbol
    /// </summary>
    public unsafe struct SecuritySymbol {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Sequence Number
    /// </summary>
    public unsafe struct SequenceNumber {
        public const int Size = 8;

        public long Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Session Id
    /// </summary>
    public unsafe struct SessionId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Session Number
    /// </summary>
    public unsafe struct SessionNumber {
        public const int Size = 1;

        public sbyte Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Strategy Add Time
    /// </summary>
    public unsafe struct StrategyAddTime {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Strategy Id
    /// </summary>
    public unsafe struct StrategyId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Strike Price
    /// </summary>
    public unsafe struct StrikePrice {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  System Status Values
    /// </summary>
    public enum SystemStatus : byte {
        StartOfSystemHours = (byte)'S',
        EndOfSystemHours = (byte)'C',
        StartTestSession = (byte)'1',
        EndOfTestSession = (byte)'2',
    };


    /// <summary>
    ///  Timestamp
    /// </summary>
    public unsafe struct Timestamp {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Top Of Market Quote Condition Values
    /// </summary>
    public enum TopOfMarketQuoteCondition : byte {
        Halted = (byte)'H',
        Resumed = (byte)'R',
        Opened = (byte)'O',
    };


    /// <summary>
    ///  Trade Condition Values
    /// </summary>
    public enum TradeCondition : byte {
        Matched = (byte)'S',
        Legged = (byte)'L',
    };


    /// <summary>
    ///  Trade Id
    /// </summary>
    public unsafe struct TradeId {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trade Size
    /// </summary>
    public unsafe struct TradeSize {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Trading Status Values
    /// </summary>
    public enum TradingStatus : byte {
        Halted = (byte)'H',
        Resumed = (byte)'R',
        Opened = (byte)'O',
    };


    /// <summary>
    ///  Underlying Symbol
    /// </summary>
    public unsafe struct UnderlyingSymbol {
        public const int Size = 11;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Update Reason Values
    /// </summary>
    public enum UpdateReason : byte {
        NewStrategyCreated = (byte)'N',
        Updated = (byte)'U',
    };


    /// <summary>
    ///  Version
    /// </summary>
    public unsafe struct Version {
        public const int Size = 8;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Wide Bid Price
    /// </summary>
    public struct WideBidPrice {
        public long Raw;
    };


    /// <summary>
    ///  Wide Bid Size
    /// </summary>
    public unsafe struct WideBidSize {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Wide Offer Price
    /// </summary>
    public struct WideOfferPrice {
        public long Raw;
    };


    /// <summary>
    ///  Wide Offer Size
    /// </summary>
    public unsafe struct WideOfferSize {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Wide Price
    /// </summary>
    public struct WidePrice {
        public long Raw;
    };


    /// <summary>
    ///  Wide Size
    /// </summary>
    public unsafe struct WideSize {
        public const int Size = 4;

        public int Value;

        public override string ToString()
            => $"{Value}";
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Application Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ApplicationMessage {
        MessageType MessageType;
    };


    /// <summary>
    ///  Struct for Complex Double Sided Top Of Market Compact Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexDoubleSidedTopOfMarketCompactMessage {
        Timestamp Timestamp;
        StrategyId StrategyId;
        CompactBidPrice CompactBidPrice;
        CompactBidSize CompactBidSize;
        BidReserved2 BidReserved2;
        BidCondition BidCondition;
        CompactOfferPrice CompactOfferPrice;
        CompactOfferSize CompactOfferSize;
        OfferReserved2 OfferReserved2;
        OfferCondition OfferCondition;
    };


    /// <summary>
    ///  Struct for Complex Strategy Definition Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexStrategyDefinitionMessage {
        StrategyAddTime StrategyAddTime;
        StrategyId StrategyId;
        UnderlyingSymbol UnderlyingSymbol;
        ActiveOnMiax ActiveOnMiax;
        Reserved1 Reserved1;
        UpdateReason UpdateReason;
        Reserved10 Reserved10;
        NumberOfLegs NumberOfLegs;
        LegDefinition LegDefinition;
    };


    /// <summary>
    ///  Struct for Complex Top Of Market Bid Compact Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexTopOfMarketBidCompactMessage {
        Timestamp Timestamp;
        StrategyId StrategyId;
        CompactPrice CompactPrice;
        CompactSize CompactSize;
        Reserved2 Reserved2;
        TopOfMarketQuoteCondition TopOfMarketQuoteCondition;
    };


    /// <summary>
    ///  Struct for Complex Top Of Market Offer Compact Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexTopOfMarketOfferCompactMessage {
        Timestamp Timestamp;
        StrategyId StrategyId;
        CompactPrice CompactPrice;
        CompactSize CompactSize;
        Reserved2 Reserved2;
        TopOfMarketQuoteCondition TopOfMarketQuoteCondition;
    };


    /// <summary>
    ///  Struct for Leg Definition
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LegDefinition {
        ProductId ProductId;
        LegRatioQty LegRatioQty;
        LegSide LegSide;
        Reserved8 Reserved8;
    };


    /// <summary>
    ///  Struct for Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Message {
        SequenceNumber SequenceNumber;
        PacketLength PacketLength;
        PacketType PacketType;
        SessionNumber SessionNumber;
    };


    /// <summary>
    ///  Struct for Packet
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Packet {
    };


    /// <summary>
    ///  Struct for Series Update
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SeriesUpdate {
        ProductAddUpdateTime ProductAddUpdateTime;
        ProductId ProductId;
        UnderlyingSymbol UnderlyingSymbol;
        SecuritySymbol SecuritySymbol;
        ExpirationDate ExpirationDate;
        StrikePrice StrikePrice;
        CallOrPut CallOrPut;
        OpeningTime OpeningTime;
        ClosingTime ClosingTime;
        RestrictedOption RestrictedOption;
        LongTermOption LongTermOption;
        ActiveOnMiax ActiveOnMiax;
        MiaxBboPostingIncrementIndicator MiaxBboPostingIncrementIndicator;
        LiquidityAcceptanceIncrementIndicator LiquidityAcceptanceIncrementIndicator;
        OpeningUnderlyingMarketCode OpeningUnderlyingMarketCode;
        PriorityQuoteWidth PriorityQuoteWidth;
        Reserved8 Reserved8;
    };


    /// <summary>
    ///  Struct for Strategy Trade Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StrategyTradeMessage {
        Timestamp Timestamp;
        StrategyId StrategyId;
        TradeId TradeId;
        NetPrice NetPrice;
        TradeSize TradeSize;
        TradeCondition TradeCondition;
        Reserved16 Reserved16;
    };


    /// <summary>
    ///  Struct for System State Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SystemStateMessage {
        NotificationTime NotificationTime;
        Version Version;
        SessionId SessionId;
        SystemStatus SystemStatus;
    };


    /// <summary>
    ///  Struct for System Time Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SystemTimeMessage {
        Timestamp Timestamp;
    };


    /// <summary>
    ///  Struct for Underlying Trading Status Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnderlyingTradingStatusMessage {
        Timestamp Timestamp;
        UnderlyingSymbol UnderlyingSymbol;
        TradingStatus TradingStatus;
        EventReason EventReason;
        SecondsPart SecondsPart;
        ExpectedEventTimeNanoSecondsPart ExpectedEventTimeNanoSecondsPart;
    };


    /// <summary>
    ///  Struct for Wide Complex Double Sided Top Of Market Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct WideComplexDoubleSidedTopOfMarketMessage {
        Timestamp Timestamp;
        StrategyId StrategyId;
        WideBidPrice WideBidPrice;
        WideBidSize WideBidSize;
        BidReserved4 BidReserved4;
        BidCondition BidCondition;
        WideOfferPrice WideOfferPrice;
        WideOfferSize WideOfferSize;
        OfferReserved4 OfferReserved4;
        OfferCondition OfferCondition;
    };


    /// <summary>
    ///  Struct for Wide Complex Top Of Market Bid Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct WideComplexTopOfMarketBidMessage {
        Timestamp Timestamp;
        StrategyId StrategyId;
        WidePrice WidePrice;
        WideSize WideSize;
        Reserved4 Reserved4;
        TopOfMarketQuoteCondition TopOfMarketQuoteCondition;
    };


    /// <summary>
    ///  Struct for Wide Complex Top Of Market Offer Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct WideComplexTopOfMarketOfferMessage {
        Timestamp Timestamp;
        StrategyId StrategyId;
        WidePrice WidePrice;
        WideSize WideSize;
        Reserved4 Reserved4;
        TopOfMarketQuoteCondition TopOfMarketQuoteCondition;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}
