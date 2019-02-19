namespace MyNamespace {

    #region Methods
    ///////////////////////////////////////////////////////////////////////

    public static class Endian {

        /// <summary>
        ///  Swap byte order for 2 byte unsigned short
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint Swap(ushort value)
            => value << 8 | value >> 8 
        
        /// <summary>
        ///  Swap byte order for 8 byte unsigned long
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint Swap(ulong value)
            => (0x00000000000000FF) & (value >> 56) |
               (0x000000000000FF00) & (value >> 40) |
               (0x0000000000FF0000) & (value >> 24) |
               (0x00000000FF000000) & (value >> 8)  |
               (0x000000FF00000000) & (value << 8)  |
               (0x0000FF0000000000) & (value << 24) |
               (0x00FF000000000000) & (value << 40) |
               (0xFF00000000000000) & (value << 56);
        
    };

    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Protocol Fields
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Auction Event Values
    /// </summary>
    public enum AuctionEvent : byte {
        Start = (byte)'S',
        AuctionUpdate = (byte)'U',
        EndOfAuction = (byte)'E',
    };


    /// <summary>
    ///  Auction Id
    /// </summary>
    public struct AuctionId {
        public uint Raw;
    };


    /// <summary>
    ///  Auction Type Values
    /// </summary>
    public enum AuctionType : byte {
        Exposure = (byte)'E',
        Facilitation = (byte)'C',
        Solicitation = (byte)'S',
        Pim = (byte)'P',
    };


    /// <summary>
    ///  Cmta
    /// </summary>
    public unsafe struct Cmta {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Count
    /// </summary>
    public struct Count {
        public ushort Raw;
    };


    /// <summary>
    ///  Current Day
    /// </summary>
    public struct CurrentDay {
        public byte Raw;
    };


    /// <summary>
    ///  Current Month
    /// </summary>
    public struct CurrentMonth {
        public byte Raw;
    };


    /// <summary>
    ///  Current Trading State Values
    /// </summary>
    public enum CurrentTradingState : byte {
        HaltInEffect = "H",
        TradingResumed = "T",
    };


    /// <summary>
    ///  Current Year
    /// </summary>
    public struct CurrentYear {
        public ushort Raw;
    };


    /// <summary>
    ///  Event Code Values
    /// </summary>
    public enum EventCode : byte {
        StartOfMessages = (byte)'O',
        StartOfSystemHours = (byte)'S',
        StartOfOpeningProcess = (byte)'Q',
        StartOfNormalHoursClosingProcess = (byte)'N',
        StartOfLateHoursClosingProcess = (byte)'L',
        EndOfSystemHours = (byte)'E',
        EndOfMessages = (byte)'C',
        EndOfWcoEarlyClosing = (byte)'W',
    };


    /// <summary>
    ///  Exec Flag Values
    /// </summary>
    public enum ExecFlag : byte {
        None = (byte)'N',
        Aon = (byte)'A',
    };


    /// <summary>
    ///  Expiration Day
    /// </summary>
    public struct ExpirationDay {
        public byte Raw;
    };


    /// <summary>
    ///  Expiration Month
    /// </summary>
    public struct ExpirationMonth {
        public byte Raw;
    };


    /// <summary>
    ///  Expiration Year
    /// </summary>
    public struct ExpirationYear {
        public byte Raw;
    };


    /// <summary>
    ///  Explicit Strike Price
    /// </summary>
    public struct ExplicitStrikePrice {
        public ulong Raw;
    };


    /// <summary>
    ///  Giveup
    /// </summary>
    public unsafe struct Giveup {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Leg Id
    /// </summary>
    public struct LegId {
        public byte Raw;
    };


    /// <summary>
    ///  Leg Ratio
    /// </summary>
    public struct LegRatio {
        public uint Raw;
    };


    /// <summary>
    ///  Length
    /// </summary>
    public struct Length {
        public ushort Raw;
    };


    /// <summary>
    ///  Message Type Values
    /// </summary>
    public enum MessageType : byte {
        SystemEventMessage = (byte)'S',
        ComplexStrategyDirectoryMessage = (byte)'R',
        StrategyTradingActionMessage = (byte)'H',
        StrategyOpenClosedMessage = (byte)'O',
        ComplexStrategyOrderOnBookMessage = (byte)'L',
        ComplexStrategyAuctionMessage = (byte)'J',
    };


    /// <summary>
    ///  Number Of Legs
    /// </summary>
    public struct NumberOfLegs {
        public byte Raw;
    };


    /// <summary>
    ///  Number Of Responses
    /// </summary>
    public struct NumberOfResponses {
        public byte Raw;
    };


    /// <summary>
    ///  Open State Values
    /// </summary>
    public enum OpenState : byte {
        OpenForAutoExecution = (byte)'Y',
        ClosedForAutoExecution = (byte)'N',
    };


    /// <summary>
    ///  Option Id
    /// </summary>
    public struct OptionId {
        public uint Raw;
    };


    /// <summary>
    ///  Option Type Values
    /// </summary>
    public enum OptionType : byte {
        Call = (byte)'C',
        Put = (byte)'P',
        Stock = (byte)' ',
    };


    /// <summary>
    ///  Order Capacity Values
    /// </summary>
    public enum OrderCapacity : byte {
        Customer = (byte)'C',
        CustomerProfessional = (byte)'D',
        Firm = (byte)'F',
        BrokerDealerCustomer = (byte)'B',
        BrokerDealerFirm = (byte)'K',
        Proprietary = (byte)'E',
        AwayMarketMaker = (byte)'N',
        MarketMaker = (byte)'M',
    };


    /// <summary>
    ///  Order Type Values
    /// </summary>
    public enum OrderType : byte {
        Market = (byte)'M',
        Limit = (byte)'L',
    };


    /// <summary>
    ///  Owner Id
    /// </summary>
    public unsafe struct OwnerId {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Price
    /// </summary>
    public struct Price {
        public uint Raw;
    };


    /// <summary>
    ///  Response Price
    /// </summary>
    public struct ResponsePrice {
        public uint Raw;
    };


    /// <summary>
    ///  Response Size
    /// </summary>
    public struct ResponseSize {
        public uint Raw;
    };


    /// <summary>
    ///  Scope Values
    /// </summary>
    public enum Scope : byte {
        Local = (byte)'L',
        National = (byte)'N',
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
    ///  Sequence
    /// </summary>
    public struct Sequence {
        public ulong Raw;
    };


    /// <summary>
    ///  Session
    /// </summary>
    public unsafe struct Session {
        public const int Size = 10;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Side Values
    /// </summary>
    public enum Side : byte {
        Bid = (byte)'B',
        OfferAsk = (byte)'A',
        Hidden = (byte)' ',
    };


    /// <summary>
    ///  Size
    /// </summary>
    public struct Size {
        public uint Raw;
    };


    /// <summary>
    ///  Source
    /// </summary>
    public struct Source {
        public byte Raw;
    };


    /// <summary>
    ///  Strategy Id
    /// </summary>
    public struct StrategyId {
        public uint Raw;
    };


    /// <summary>
    ///  Strategy Type Values
    /// </summary>
    public enum StrategyType : byte {
        VerticalSpread = (byte)'V',
        TimeSpread = (byte)'T',
        DiagonalSpread = (byte)'D',
        Straddle = (byte)'S',
        Strangle = (byte)'G',
        Combo = (byte)'C',
        RiskReversal = (byte)'R',
        RatioSpread = (byte)'A',
        Custom = (byte)'U',
    };


    /// <summary>
    ///  Subversion
    /// </summary>
    public struct Subversion {
        public byte Raw;
    };


    /// <summary>
    ///  Timestamp
    /// </summary>
    public struct Timestamp {
        public ulong Raw;
    };


    /// <summary>
    ///  Underlying Symbol
    /// </summary>
    public unsafe struct UnderlyingSymbol {
        public const int Size = 13;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Version
    /// </summary>
    public struct Version {
        public byte Raw;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Auction Response
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AuctionResponse {
        ResponsePrice ResponsePrice;
        ResponseSize ResponseSize;
    };


    /// <summary>
    ///  Struct for Complex Strategy Auction Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexStrategyAuctionMessage {
        Timestamp Timestamp;
        StrategyId StrategyId;
        AuctionId AuctionId;
        OrderType OrderType;
        Side Side;
        Price Price;
        Size Size;
        ExecFlag ExecFlag;
        OrderCapacity OrderCapacity;
        Scope Scope;
        OwnerId OwnerId;
        Giveup Giveup;
        Cmta Cmta;
        AuctionEvent AuctionEvent;
        AuctionType AuctionType;
        NumberOfResponses NumberOfResponses;
    };


    /// <summary>
    ///  Struct for Complex Strategy Directory Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexStrategyDirectoryMessage {
        Timestamp Timestamp;
        StrategyId StrategyId;
        StrategyType StrategyType;
        Source Source;
        UnderlyingSymbol UnderlyingSymbol;
        NumberOfLegs NumberOfLegs;
    };


    /// <summary>
    ///  Struct for Complex Strategy Order On Book Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ComplexStrategyOrderOnBookMessage {
        Timestamp Timestamp;
        StrategyId StrategyId;
        OrderType OrderType;
        Side Side;
        Price Price;
        Size Size;
        ExecFlag ExecFlag;
        OrderCapacity OrderCapacity;
        Scope Scope;
        OwnerId OwnerId;
        Giveup Giveup;
        Cmta Cmta;
    };


    /// <summary>
    ///  Struct for Leg Information
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LegInformation {
        OptionId OptionId;
        SecuritySymbol SecuritySymbol;
        LegId LegId;
        ExpirationYear ExpirationYear;
        ExpirationMonth ExpirationMonth;
        ExpirationDay ExpirationDay;
        ExplicitStrikePrice ExplicitStrikePrice;
        OptionType OptionType;
        Side Side;
        LegRatio LegRatio;
    };


    /// <summary>
    ///  Struct for Message Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MessageHeader {
        Length Length;
        MessageType MessageType;
    };


    /// <summary>
    ///  Struct for Packet Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PacketHeader {
        Session Session;
        Sequence Sequence;
        Count Count;
    };


    /// <summary>
    ///  Struct for Strategy Open Closed Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StrategyOpenClosedMessage {
        Timestamp Timestamp;
        StrategyId StrategyId;
        OpenState OpenState;
    };


    /// <summary>
    ///  Struct for Strategy Trading Action Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct StrategyTradingActionMessage {
        Timestamp Timestamp;
        StrategyId StrategyId;
        CurrentTradingState CurrentTradingState;
    };


    /// <summary>
    ///  Struct for System Event Message
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SystemEventMessage {
        Timestamp Timestamp;
        EventCode EventCode;
        CurrentYear CurrentYear;
        CurrentMonth CurrentMonth;
        CurrentDay CurrentDay;
        Version Version;
        Subversion Subversion;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}