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
        ///  Swap byte order in unsigned integer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint Swap(uint value)
            => (value & 0x000000FF) << 24 |
               (value & 0x0000FF00) << 8  |
               (value & 0x00FF0000) >> 8  |
               (value & 0xFF000000) >> 24;
        
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
    ///  Actual
    /// </summary>
    public unsafe struct Actual {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Aggressor Side Values
    /// </summary>
    public enum AggressorSide : byte {
        AggressorSide = "0",
        AggressorSide = "1",
        AggressorSide = "2",
    };


    /// <summary>
    ///  Appl Id
    /// </summary>
    public struct ApplId {
        public short Raw;
    };


    /// <summary>
    ///  Asset
    /// </summary>
    public unsafe struct Asset {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Block Length
    /// </summary>
    public struct BlockLength {
        public ushort Raw;
    };


    /// <summary>
    ///  Block Trade Eligible
    /// </summary>
    public unsafe struct BlockTradeEligible {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Cfi Code
    /// </summary>
    public unsafe struct CfiCode {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Cleared Volume
    /// </summary>
    public struct ClearedVolume {
        public int Raw;
    };


    /// <summary>
    ///  Contract Multiplier
    /// </summary>
    public struct ContractMultiplier {
        public int Raw;
    };


    /// <summary>
    ///  Contract Multiplier Unit
    /// </summary>
    public struct ContractMultiplierUnit {
        public sbyte Raw;
    };


    /// <summary>
    ///  Currency
    /// </summary>
    public unsafe struct Currency {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Daily Product Eligibility
    /// </summary>
    public unsafe struct DailyProductEligibility {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Day
    /// </summary>
    public struct Day {
        public byte Raw;
    };


    /// <summary>
    ///  Decay Quantity
    /// </summary>
    public struct DecayQuantity {
        public int Raw;
    };


    /// <summary>
    ///  Decay Start Date
    /// </summary>
    public struct DecayStartDate {
        public ushort Raw;
    };


    /// <summary>
    ///  Decaying Product Eligibility
    /// </summary>
    public unsafe struct DecayingProductEligibility {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Display Factor
    /// </summary>
    public struct DisplayFactor {
        public long Raw;
    };


    /// <summary>
    ///  Ebf Eligible
    /// </summary>
    public unsafe struct EbfEligible {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Efp Eligible
    /// </summary>
    public unsafe struct EfpEligible {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Efr Eligible
    /// </summary>
    public unsafe struct EfrEligible {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Efs Eligible
    /// </summary>
    public unsafe struct EfsEligible {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Electronic Match Eligible
    /// </summary>
    public unsafe struct ElectronicMatchEligible {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  End Of Event
    /// </summary>
    public unsafe struct EndOfEvent {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Event Time
    /// </summary>
    public struct EventTime {
        public ulong Raw;
    };


    /// <summary>
    ///  Event Type Values
    /// </summary>
    public enum EventType : byte {
        EventType = "5",
        EventType = "7",
    };


    /// <summary>
    ///  Final
    /// </summary>
    public unsafe struct Final {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Flow Schedule Type
    /// </summary>
    public struct FlowScheduleType {
        public sbyte Raw;
    };


    /// <summary>
    ///  Gt Orders Eligibility
    /// </summary>
    public unsafe struct GtOrdersEligibility {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Halt Reason Values
    /// </summary>
    public enum HaltReason : byte {
        HaltReason = "0",
        HaltReason = "1",
        HaltReason = "2",
        HaltReason = "3",
        HaltReason = "4",
        HaltReason = "5",
        HaltReason = "6",
    };


    /// <summary>
    ///  Heart Bt Int
    /// </summary>
    public struct HeartBtInt {
        public sbyte Raw;
    };


    /// <summary>
    ///  High Limit Price
    /// </summary>
    public struct HighLimitPrice {
        public long Raw;
    };


    /// <summary>
    ///  I Link Indicative Mass Quoting Eligible
    /// </summary>
    public unsafe struct ILinkIndicativeMassQuotingEligible {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Implied Matching Eligibility
    /// </summary>
    public unsafe struct ImpliedMatchingEligibility {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Intraday
    /// </summary>
    public unsafe struct Intraday {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Is Fractional
    /// </summary>
    public unsafe struct IsFractional {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Last Implied Msg
    /// </summary>
    public unsafe struct LastImpliedMsg {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Last Msg Seq Num Processed
    /// </summary>
    public struct LastMsgSeqNumProcessed {
        public uint Raw;
    };


    /// <summary>
    ///  Last Qty
    /// </summary>
    public struct LastQty {
        public int Raw;
    };


    /// <summary>
    ///  Last Quote Msg
    /// </summary>
    public unsafe struct LastQuoteMsg {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Last Stats Msg
    /// </summary>
    public unsafe struct LastStatsMsg {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Last Trade Msg
    /// </summary>
    public unsafe struct LastTradeMsg {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Last Update Time
    /// </summary>
    public struct LastUpdateTime {
        public ulong Raw;
    };


    /// <summary>
    ///  Last Volume Msg
    /// </summary>
    public unsafe struct LastVolumeMsg {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Leg Option Delta
    /// </summary>
    public struct LegOptionDelta {
        public int Raw;
    };


    /// <summary>
    ///  Leg Price
    /// </summary>
    public struct LegPrice {
        public long Raw;
    };


    /// <summary>
    ///  Leg Ratio Qty
    /// </summary>
    public struct LegRatioQty {
        public sbyte Raw;
    };


    /// <summary>
    ///  Leg Security Id
    /// </summary>
    public struct LegSecurityId {
        public int Raw;
    };


    /// <summary>
    ///  Leg Side Values
    /// </summary>
    public enum LegSide : byte {
        LegSide = "1",
        LegSide = "2",
    };


    /// <summary>
    ///  Lot Type
    /// </summary>
    public struct LotType {
        public sbyte Raw;
    };


    /// <summary>
    ///  Low Limit Price
    /// </summary>
    public struct LowLimitPrice {
        public long Raw;
    };


    /// <summary>
    ///  Main Fraction
    /// </summary>
    public struct MainFraction {
        public byte Raw;
    };


    /// <summary>
    ///  Market Depth
    /// </summary>
    public struct MarketDepth {
        public sbyte Raw;
    };


    /// <summary>
    ///  Market Segment Id
    /// </summary>
    public struct MarketSegmentId {
        public byte Raw;
    };


    /// <summary>
    ///  Match Algorithm
    /// </summary>
    public unsafe struct MatchAlgorithm {
        public const int Size = 1;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Max Price Variation
    /// </summary>
    public struct MaxPriceVariation {
        public long Raw;
    };


    /// <summary>
    ///  Max Trade Vol
    /// </summary>
    public struct MaxTradeVol {
        public uint Raw;
    };


    /// <summary>
    ///  Md Entry Px
    /// </summary>
    public struct MdEntryPx {
        public long Raw;
    };


    /// <summary>
    ///  Md Entry Size
    /// </summary>
    public struct MdEntrySize {
        public int Raw;
    };


    /// <summary>
    ///  Md Entry Type Values
    /// </summary>
    public enum MdEntryType : byte {
        MdEntryType = (byte)'0',
        MdEntryType = (byte)'1',
        MdEntryType = (byte)'2',
        MdEntryType = (byte)'4',
        MdEntryType = (byte)'6',
        MdEntryType = (byte)'7',
        MdEntryType = (byte)'8',
        MdEntryType = (byte)'B',
        MdEntryType = (byte)'C',
        MdEntryType = (byte)'E',
        MdEntryType = (byte)'F',
        MdEntryType = (byte)'J',
        MdEntryType = (byte)'N',
        MdEntryType = (byte)'O',
        MdEntryType = (byte)'W',
        MdEntryType = (byte)'e',
        MdEntryType = (byte)'g',
    };


    /// <summary>
    ///  Md Feed Type
    /// </summary>
    public unsafe struct MdFeedType {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Md Price Level
    /// </summary>
    public struct MdPriceLevel {
        public byte Raw;
    };


    /// <summary>
    ///  Md Security Trading Status
    /// </summary>
    public struct MdSecurityTradingStatus {
        public byte Raw;
    };


    /// <summary>
    ///  Md Update Action Values
    /// </summary>
    public enum MdUpdateAction : byte {
        MdUpdateAction = "0",
        MdUpdateAction = "1",
        MdUpdateAction = "2",
        MdUpdateAction = "3",
        MdUpdateAction = "4",
        MdUpdateAction = "5",
    };


    /// <summary>
    ///  Message Sequence Number
    /// </summary>
    public struct MessageSequenceNumber {
        public uint Raw;
    };


    /// <summary>
    ///  Message Size
    /// </summary>
    public struct MessageSize {
        public ushort Raw;
    };


    /// <summary>
    ///  Min Cab Price
    /// </summary>
    public struct MinCabPrice {
        public long Raw;
    };


    /// <summary>
    ///  Min Lot Size
    /// </summary>
    public struct MinLotSize {
        public int Raw;
    };


    /// <summary>
    ///  Min Price Increment
    /// </summary>
    public struct MinPriceIncrement {
        public long Raw;
    };


    /// <summary>
    ///  Min Price Increment Amount
    /// </summary>
    public struct MinPriceIncrementAmount {
        public long Raw;
    };


    /// <summary>
    ///  Min Trade Vol
    /// </summary>
    public struct MinTradeVol {
        public uint Raw;
    };


    /// <summary>
    ///  Month
    /// </summary>
    public struct Month {
        public byte Raw;
    };


    /// <summary>
    ///  Negative Price Outright Eligible
    /// </summary>
    public unsafe struct NegativePriceOutrightEligible {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Negative Strike Eligible
    /// </summary>
    public unsafe struct NegativeStrikeEligible {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Null Value
    /// </summary>
    public unsafe struct NullValue {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Num In Group
    /// </summary>
    public struct NumInGroup {
        public byte Raw;
    };


    /// <summary>
    ///  Number Of Orders
    /// </summary>
    public struct NumberOfOrders {
        public int Raw;
    };


    /// <summary>
    ///  Open Close Settl Flag Values
    /// </summary>
    public enum OpenCloseSettlFlag : byte {
        OpenCloseSettlFlag = "0",
        OpenCloseSettlFlag = "5",
    };


    /// <summary>
    ///  Open Interest Qty
    /// </summary>
    public struct OpenInterestQty {
        public int Raw;
    };


    /// <summary>
    ///  Order Cross Eligible
    /// </summary>
    public unsafe struct OrderCrossEligible {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Order Id
    /// </summary>
    public struct OrderId {
        public ulong Raw;
    };


    /// <summary>
    ///  Order Qty
    /// </summary>
    public struct OrderQty {
        public int Raw;
    };


    /// <summary>
    ///  Original Contract Size
    /// </summary>
    public struct OriginalContractSize {
        public int Raw;
    };


    /// <summary>
    ///  Otc Eligible
    /// </summary>
    public unsafe struct OtcEligible {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Padding 2
    /// </summary>
    public unsafe struct Padding2 {
        public const int Size = 2;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Padding 3
    /// </summary>
    public unsafe struct Padding3 {
        public const int Size = 3;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Padding 4
    /// </summary>
    public unsafe struct Padding4 {
        public const int Size = 4;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Padding 5
    /// </summary>
    public unsafe struct Padding5 {
        public const int Size = 5;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Padding 6
    /// </summary>
    public unsafe struct Padding6 {
        public const int Size = 6;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Padding 7
    /// </summary>
    public unsafe struct Padding7 {
        public const int Size = 7;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Price Display Format
    /// </summary>
    public struct PriceDisplayFormat {
        public byte Raw;
    };


    /// <summary>
    ///  Price Ratio
    /// </summary>
    public struct PriceRatio {
        public long Raw;
    };


    /// <summary>
    ///  Put Or Call Values
    /// </summary>
    public enum PutOrCall : byte {
        PutOrCall = "0",
        PutOrCall = "1",
    };


    /// <summary>
    ///  Quote Req Id
    /// </summary>
    public unsafe struct QuoteReqId {
        public const int Size = 23;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Quote Type
    /// </summary>
    public struct QuoteType {
        public sbyte Raw;
    };


    /// <summary>
    ///  Recovery Msg
    /// </summary>
    public unsafe struct RecoveryMsg {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved
    /// </summary>
    public unsafe struct Reserved {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved 12
    /// </summary>
    public unsafe struct Reserved12 {
        public const int Size = 12;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Reserved Bits
    /// </summary>
    public unsafe struct ReservedBits {
        public const int Size = 3;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Rfq Cross Eligible
    /// </summary>
    public unsafe struct RfqCrossEligible {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Rounded
    /// </summary>
    public unsafe struct Rounded {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Rpt Seq
    /// </summary>
    public struct RptSeq {
        public uint Raw;
    };


    /// <summary>
    ///  Schema Id
    /// </summary>
    public struct SchemaId {
        public ushort Raw;
    };


    /// <summary>
    ///  Security Exchange
    /// </summary>
    public unsafe struct SecurityExchange {
        public const int Size = 4;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Group
    /// </summary>
    public unsafe struct SecurityGroup {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Id
    /// </summary>
    public struct SecurityId {
        public int Raw;
    };


    /// <summary>
    ///  Security Sub Type
    /// </summary>
    public unsafe struct SecuritySubType {
        public const int Size = 5;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Trading Event Values
    /// </summary>
    public enum SecurityTradingEvent : byte {
        SecurityTradingEvent = "0",
        SecurityTradingEvent = "1",
        SecurityTradingEvent = "4",
        SecurityTradingEvent = "5",
        SecurityTradingEvent = "6",
    };


    /// <summary>
    ///  Security Trading Status Values
    /// </summary>
    public enum SecurityTradingStatus : byte {
        SecurityTradingStatus = "2",
        SecurityTradingStatus = "4",
        SecurityTradingStatus = "15",
        SecurityTradingStatus = "17",
        SecurityTradingStatus = "18",
        SecurityTradingStatus = "20",
        SecurityTradingStatus = "21",
        SecurityTradingStatus = "24",
        SecurityTradingStatus = "25",
        SecurityTradingStatus = "26",
        SecurityTradingStatus = "103",
    };


    /// <summary>
    ///  Security Type
    /// </summary>
    public unsafe struct SecurityType {
        public const int Size = 6;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Security Update Action Values
    /// </summary>
    public enum SecurityUpdateAction : byte {
        SecurityUpdateAction = (byte)'A',
        SecurityUpdateAction = (byte)'D',
        SecurityUpdateAction = (byte)'M',
    };


    /// <summary>
    ///  Sending Time
    /// </summary>
    public struct SendingTime {
        public ulong Raw;
    };


    /// <summary>
    ///  Settl Currency
    /// </summary>
    public unsafe struct SettlCurrency {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Side
    /// </summary>
    public struct Side {
        public sbyte Raw;
    };


    /// <summary>
    ///  Strike Currency
    /// </summary>
    public unsafe struct StrikeCurrency {
        public const int Size = 3;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Strike Price
    /// </summary>
    public struct StrikePrice {
        public long Raw;
    };


    /// <summary>
    ///  Sub Fraction
    /// </summary>
    public struct SubFraction {
        public byte Raw;
    };


    /// <summary>
    ///  Symbol
    /// </summary>
    public unsafe struct Symbol {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Template Id Values
    /// </summary>
    public enum TemplateId : ushort {
        ChannelReset = "4",
        AdminHeartbeat = "12",
        AdminLogin = "15",
        AdminLogout = "16",
        MdInstrumentDefinitionFuture = "27",
        MdInstrumentDefinitionSpread = "29",
        SecurityStatus = "30",
        MdIncrementalRefreshBook = "32",
        MdIncrementalRefreshDailyStatistics = "33",
        MdIncrementalRefreshLimitsBanding = "34",
        MdIncrementalRefreshSessionStatistics = "35",
        MdIncrementalRefreshTrade = "36",
        MdIncrementalRefreshVolume = "37",
        SnapshotFullRefresh = "38",
        QuoteRequest = "39",
        MdInstrumentDefinitionOption = "41",
        MdIncrementalRefreshTradeSummary = "42",
    };


    /// <summary>
    ///  Text
    /// </summary>
    public unsafe struct Text {
        public const int Size = 180;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Tick Rule
    /// </summary>
    public struct TickRule {
        public sbyte Raw;
    };


    /// <summary>
    ///  Tot Num Reports
    /// </summary>
    public struct TotNumReports {
        public uint Raw;
    };


    /// <summary>
    ///  Trade Date
    /// </summary>
    public struct TradeDate {
        public ushort Raw;
    };


    /// <summary>
    ///  Trade Id
    /// </summary>
    public struct TradeId {
        public int Raw;
    };


    /// <summary>
    ///  Trading Reference Date
    /// </summary>
    public struct TradingReferenceDate {
        public ushort Raw;
    };


    /// <summary>
    ///  Trading Reference Price
    /// </summary>
    public struct TradingReferencePrice {
        public long Raw;
    };


    /// <summary>
    ///  Transact Time
    /// </summary>
    public struct TransactTime {
        public ulong Raw;
    };


    /// <summary>
    ///  Underlying Product
    /// </summary>
    public struct UnderlyingProduct {
        public byte Raw;
    };


    /// <summary>
    ///  Underlying Security Id
    /// </summary>
    public struct UnderlyingSecurityId {
        public int Raw;
    };


    /// <summary>
    ///  Underlying Symbol
    /// </summary>
    public unsafe struct UnderlyingSymbol {
        public const int Size = 20;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Unit Of Measure
    /// </summary>
    public unsafe struct UnitOfMeasure {
        public const int Size = 30;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Unit Of Measure Qty
    /// </summary>
    public struct UnitOfMeasureQty {
        public long Raw;
    };


    /// <summary>
    ///  User Defined Instrument
    /// </summary>
    public unsafe struct UserDefinedInstrument {
        public const int Size = 1;

        public fixed sbyte Bytes[Size];

        public string Value
            => new String((sbyte*)Bytes, 0, Size);

        public override string ToString()
            => $"{Value}";
    };


    /// <summary>
    ///  Variable Product Eligibility
    /// </summary>
    public unsafe struct VariableProductEligibility {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Version
    /// </summary>
    public struct Version {
        public ushort Raw;
    };


    /// <summary>
    ///  Volatility Quoted Option
    /// </summary>
    public unsafe struct VolatilityQuotedOption {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    /// <summary>
    ///  Week
    /// </summary>
    public struct Week {
        public byte Raw;
    };


    /// <summary>
    ///  Year
    /// </summary>
    public struct Year {
        public ushort Raw;
    };


    /// <summary>
    ///  Zero Price Outright Eligible
    /// </summary>
    public unsafe struct ZeroPriceOutrightEligible {
        public const int Size = 1;

        public fixed byte Bytes[Size];
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

    #region Structs
    ///////////////////////////////////////////////////////////////////////

    /// <summary>
    ///  Struct for Admin Login 15
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AdminLogin15 {
        HeartBtInt HeartBtInt;
    };


    /// <summary>
    ///  Struct for Admin Logout 16
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct AdminLogout16 {
        Text Text;
    };


    /// <summary>
    ///  Struct for Channel Reset 4
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ChannelReset4 {
        TransactTime TransactTime;
        MatchEventIndicator MatchEventIndicator;
    };


    /// <summary>
    ///  Struct for Channel Reset Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ChannelResetGroup {
        ApplId ApplId;
    };


    /// <summary>
    ///  Struct for Channel Reset Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ChannelResetGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Events Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EventsGroup {
        EventType EventType;
        EventTime EventTime;
    };


    /// <summary>
    ///  Struct for Events Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct EventsGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Group Size
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct GroupSize {
        BlockLength BlockLength;
        NumInGroup NumInGroup;
    };


    /// <summary>
    ///  Struct for Group Size8 Byte
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct GroupSize8Byte {
        BlockLength BlockLength;
        Padding5 Padding5;
        NumInGroup NumInGroup;
    };


    /// <summary>
    ///  Struct for Inst Attrib Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InstAttribGroup {
        InstAttribValue InstAttribValue;
    };


    /// <summary>
    ///  Struct for Inst Attrib Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InstAttribGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Inst Attrib Value
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct InstAttribValue {
        Reserved12 Reserved12;
        ImpliedMatchingEligibility ImpliedMatchingEligibility;
        GtOrdersEligibility GtOrdersEligibility;
        DailyProductEligibility DailyProductEligibility;
        VariableProductEligibility VariableProductEligibility;
        DecayingProductEligibility DecayingProductEligibility;
        ZeroPriceOutrightEligible ZeroPriceOutrightEligible;
        RfqCrossEligible RfqCrossEligible;
        VolatilityQuotedOption VolatilityQuotedOption;
        IsFractional IsFractional;
        NegativePriceOutrightEligible NegativePriceOutrightEligible;
        NegativeStrikeEligible NegativeStrikeEligible;
        ILinkIndicativeMassQuotingEligible ILinkIndicativeMassQuotingEligible;
        OtcEligible OtcEligible;
        EfrEligible EfrEligible;
        EfsEligible EfsEligible;
        EbfEligible EbfEligible;
        EfpEligible EfpEligible;
        BlockTradeEligible BlockTradeEligible;
        OrderCrossEligible OrderCrossEligible;
        ElectronicMatchEligible ElectronicMatchEligible;
    };


    /// <summary>
    ///  Struct for Legs Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LegsGroup {
        LegSecurityId LegSecurityId;
        LegSide LegSide;
        LegRatioQty LegRatioQty;
        LegPrice LegPrice;
        LegOptionDelta LegOptionDelta;
    };


    /// <summary>
    ///  Struct for Legs Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LegsGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Lot Type Rules Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LotTypeRulesGroup {
        LotType LotType;
        MinLotSize MinLotSize;
    };


    /// <summary>
    ///  Struct for Lot Type Rules Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct LotTypeRulesGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Match Event Indicator
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MatchEventIndicator {
        EndOfEvent EndOfEvent;
        Reserved Reserved;
        RecoveryMsg RecoveryMsg;
        LastImpliedMsg LastImpliedMsg;
        LastStatsMsg LastStatsMsg;
        LastQuoteMsg LastQuoteMsg;
        LastVolumeMsg LastVolumeMsg;
        LastTradeMsg LastTradeMsg;
    };


    /// <summary>
    ///  Struct for Maturity Month Year
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MaturityMonthYear {
        Year Year;
        Month Month;
        Day Day;
        Week Week;
    };


    /// <summary>
    ///  Struct for MD Feed Types Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdFeedTypesGroup {
        MdFeedType MdFeedType;
        MarketDepth MarketDepth;
    };


    /// <summary>
    ///  Struct for MD Feed Types Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdFeedTypesGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Md Incremental Refresh Book 32
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshBook32 {
        TransactTime TransactTime;
        MatchEventIndicator MatchEventIndicator;
        Padding2 Padding2;
    };


    /// <summary>
    ///  Struct for MD Incremental Refresh Book Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshBookGroup {
        MdEntryPx MdEntryPx;
        MdEntrySize MdEntrySize;
        SecurityId SecurityId;
        RptSeq RptSeq;
        NumberOfOrders NumberOfOrders;
        MdPriceLevel MdPriceLevel;
        MdUpdateAction MdUpdateAction;
        MdEntryType MdEntryType;
        Padding5 Padding5;
    };


    /// <summary>
    ///  Struct for MD Incremental Refresh Book Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshBookGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Md Incremental Refresh Daily Statistics 33
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshDailyStatistics33 {
        TransactTime TransactTime;
        MatchEventIndicator MatchEventIndicator;
        Padding2 Padding2;
    };


    /// <summary>
    ///  Struct for MD Incremental Refresh Daily Statistics Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshDailyStatisticsGroup {
        MdEntryPx MdEntryPx;
        MdEntrySize MdEntrySize;
        SecurityId SecurityId;
        RptSeq RptSeq;
        TradingReferenceDate TradingReferenceDate;
        SettlPriceType SettlPriceType;
        MdUpdateAction MdUpdateAction;
        MdEntryType MdEntryType;
        Padding7 Padding7;
    };


    /// <summary>
    ///  Struct for MD Incremental Refresh Daily Statistics Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshDailyStatisticsGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Md Incremental Refresh Limits Banding 34
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshLimitsBanding34 {
        TransactTime TransactTime;
        MatchEventIndicator MatchEventIndicator;
        Padding2 Padding2;
    };


    /// <summary>
    ///  Struct for MD Incremental Refresh Limits Banding Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshLimitsBandingGroup {
        HighLimitPrice HighLimitPrice;
        LowLimitPrice LowLimitPrice;
        MaxPriceVariation MaxPriceVariation;
        SecurityId SecurityId;
        RptSeq RptSeq;
    };


    /// <summary>
    ///  Struct for MD Incremental Refresh Limits Banding Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshLimitsBandingGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Md Incremental Refresh Session Statistics 35
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshSessionStatistics35 {
        TransactTime TransactTime;
        MatchEventIndicator MatchEventIndicator;
        Padding2 Padding2;
    };


    /// <summary>
    ///  Struct for MD Incremental Refresh Session Statistics Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshSessionStatisticsGroup {
        MdEntryPx MdEntryPx;
        SecurityId SecurityId;
        RptSeq RptSeq;
        OpenCloseSettlFlag OpenCloseSettlFlag;
        MdUpdateAction MdUpdateAction;
        MdEntryType MdEntryType;
        Padding5 Padding5;
    };


    /// <summary>
    ///  Struct for MD Incremental Refresh Session Statistics Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshSessionStatisticsGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Md Incremental Refresh Trade 36
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshTrade36 {
        TransactTime TransactTime;
        MatchEventIndicator MatchEventIndicator;
        Padding2 Padding2;
    };


    /// <summary>
    ///  Struct for MD Incremental Refresh Trade Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshTradeGroup {
        MdEntryPx MdEntryPx;
        MdEntrySize MdEntrySize;
        SecurityId SecurityId;
        RptSeq RptSeq;
        NumberOfOrders NumberOfOrders;
        TradeId TradeId;
        AggressorSide AggressorSide;
        MdUpdateAction MdUpdateAction;
        Padding2 Padding2;
    };


    /// <summary>
    ///  Struct for MD Incremental Refresh Trade Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshTradeGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for MD Incremental Refresh Trade Summary Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshTradeSummaryGroup {
        MdEntryPx MdEntryPx;
        MdEntrySize MdEntrySize;
        SecurityId SecurityId;
        RptSeq RptSeq;
        NumberOfOrders NumberOfOrders;
        AggressorSide AggressorSide;
        MdUpdateAction MdUpdateAction;
        Padding6 Padding6;
    };


    /// <summary>
    ///  Struct for MD Incremental Refresh Trade Summary Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshTradeSummaryGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for MD Incremental Refresh Trade Summary Order Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshTradeSummaryOrderGroup {
        OrderId OrderId;
        LastQty LastQty;
        Padding4 Padding4;
    };


    /// <summary>
    ///  Struct for MD Incremental Refresh Trade Summary Order Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshTradeSummaryOrderGroups {
        GroupSize8Byte GroupSize8Byte;
    };


    /// <summary>
    ///  Struct for Md Incremental Refresh Volume 37
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshVolume37 {
        TransactTime TransactTime;
        MatchEventIndicator MatchEventIndicator;
        Padding2 Padding2;
    };


    /// <summary>
    ///  Struct for MD Incremental Refresh Volume Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshVolumeGroup {
        MdEntrySize MdEntrySize;
        SecurityId SecurityId;
        RptSeq RptSeq;
        MdUpdateAction MdUpdateAction;
        Padding3 Padding3;
    };


    /// <summary>
    ///  Struct for MD Incremental Refresh Volume Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MdIncrementalRefreshVolumeGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Message Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MessageHeader {
        MessageSize MessageSize;
        BlockLength BlockLength;
        TemplateId TemplateId;
        SchemaId SchemaId;
        Version Version;
    };


    /// <summary>
    ///  Struct for Packet Header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct PacketHeader {
        MessageSequenceNumber MessageSequenceNumber;
        SendingTime SendingTime;
    };


    /// <summary>
    ///  Struct for Quote Request 39
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct QuoteRequest39 {
        TransactTime TransactTime;
        QuoteReqId QuoteReqId;
        MatchEventIndicator MatchEventIndicator;
        Padding3 Padding3;
    };


    /// <summary>
    ///  Struct for Related Sym Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RelatedSymGroup {
        Symbol Symbol;
        SecurityId SecurityId;
        OrderQty OrderQty;
        QuoteType QuoteType;
        Side Side;
        Padding2 Padding2;
    };


    /// <summary>
    ///  Struct for Related Sym Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RelatedSymGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Security Status 30
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SecurityStatus30 {
        TransactTime TransactTime;
        SecurityGroup SecurityGroup;
        Asset Asset;
        SecurityId SecurityId;
        TradeDate TradeDate;
        MatchEventIndicator MatchEventIndicator;
        SecurityTradingStatus SecurityTradingStatus;
        HaltReason HaltReason;
        SecurityTradingEvent SecurityTradingEvent;
    };


    /// <summary>
    ///  Struct for Settl Price Type
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SettlPriceType {
        NullValue NullValue;
        ReservedBits ReservedBits;
        Intraday Intraday;
        Rounded Rounded;
        Actual Actual;
        Final Final;
    };


    /// <summary>
    ///  Struct for Snapshot Full Refresh 38
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SnapshotFullRefresh38 {
        LastMsgSeqNumProcessed LastMsgSeqNumProcessed;
        TotNumReports TotNumReports;
        SecurityId SecurityId;
        RptSeq RptSeq;
        TransactTime TransactTime;
        LastUpdateTime LastUpdateTime;
        TradeDate TradeDate;
        MdSecurityTradingStatus MdSecurityTradingStatus;
        HighLimitPrice HighLimitPrice;
        LowLimitPrice LowLimitPrice;
        MaxPriceVariation MaxPriceVariation;
    };


    /// <summary>
    ///  Struct for Snapshot Full Refresh Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SnapshotFullRefreshGroup {
        MdEntryPx MdEntryPx;
        MdEntrySize MdEntrySize;
        NumberOfOrders NumberOfOrders;
        MdPriceLevel MdPriceLevel;
        TradingReferenceDate TradingReferenceDate;
        OpenCloseSettlFlag OpenCloseSettlFlag;
        SettlPriceType SettlPriceType;
        MdEntryType MdEntryType;
    };


    /// <summary>
    ///  Struct for Snapshot Full Refresh Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct SnapshotFullRefreshGroups {
        GroupSize GroupSize;
    };


    /// <summary>
    ///  Struct for Underlyings Group
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnderlyingsGroup {
        UnderlyingSecurityId UnderlyingSecurityId;
        UnderlyingSymbol UnderlyingSymbol;
    };


    /// <summary>
    ///  Struct for Underlyings Groups
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct UnderlyingsGroups {
        GroupSize GroupSize;
    };


    ///////////////////////////////////////////////////////////////////////
    #endregion

}