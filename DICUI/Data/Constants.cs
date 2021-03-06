﻿namespace DICUI.Data
{
    /// <summary>
    /// Variables for UI elements
    /// </summary>
    public static class UIElements
    {
        public const string DiscNotDetected = "Disc Not Detected";
        public const string StartDumping = "Start Dumping";
        public const string StopDumping = "Stop Dumping";

        public const int LogWindowMarginFromMainWindow = 10;
    }

    /// <summary>
    /// Top-level commands for DiscImageCreator
    /// </summary>
    public static class DICCommandStrings
    {
        public const string Audio = "audio";
        public const string BluRay = "bd";
        public const string Close = "close";
        public const string CompactDisc = "cd";
        public const string Data = "data";
        public const string DigitalVideoDisc = "dvd";
        public const string DriveSpeed = "ls";
        public const string Eject = "eject";
        public const string Floppy = "fd";
        public const string GDROM = "gd";
        public const string MDS = "mds";
        public const string Reset = "reset";
        public const string Start = "start";
        public const string Stop = "stop";
        public const string Sub = "sub";
        public const string Swap = "swap";
        public const string XBOX = "xbox";
        public const string XBOXSwap = "xboxswap";
        public const string XGD2Swap = "xgd2swap";
        public const string XGD3Swap = "xgd3swap";
    }

    /// <summary>
    /// Dumping flags for DiscImageCreator
    /// </summary>
    public static class DICFlagStrings
    {
        public const string AddOffset = "/a";
        public const string AMSF = "/p";
        public const string BEOpcode = "/be";
        public const string C2Opcode = "/c2";
        public const string CopyrightManagementInformation = "/c";
        public const string D8Opcode = "/d8";
        public const string DisableBeep = "/q";
        public const string ForceUnitAccess = "/f";
        public const string MCN = "/m";
        public const string MultiSession = "/ms";
        public const string NoFixSubP = "/np";
        public const string NoFixSubQ = "/nq";
        public const string NoFixSubQLibCrypt = "/nl";
        public const string NoFixSubQSecuROM = "/ns";
        public const string NoFixSubRtoW = "/nr";
        public const string Raw = "/raw";
        public const string Reverse = "/r";
        public const string ScanAntiMod = "/am";
        public const string ScanFileProtect = "/sf";
        public const string ScanSectorProtect = "/ss";
        public const string SeventyFour = "/74";
        public const string SubchannelReadLevel = "/s";
    }

    /// <summary>
    /// Template field values for submission info
    /// </summary>
    public static class Template
    {
        // Manual information

        public const string TitleField = "Title";
        public const string DiscNumberField = "Disc Number / Letter";
        public const string DiscTitleField = "Disc Title";
        public const string SystemField = "System";
        public const string MediaTypeField = "Media Type";
        public const string CategoryField = "Category";
        public const string RegionField = "Region";
        public const string LanguagesField = "Languages";
        public const string DiscSerialField = "Disc Serial";
        public const string BarcodeField = "Barcode";
        public const string ISBNField = "ISBN";
        public const string CommentsField = "Comments";
        public const string ContentsField = "Contents";
        public const string VersionField = "Version";
        public const string EditionField = "Edition/Release";
        public const string CopyProtectionField = "Copy Protection";
        public const string MasteringRingField = "Mastering Ring";
        public const string MasteringSIDField = "Mastering SID Code";
        public const string MouldSIDField = "Mould SID Code";
        public const string AdditionalMouldField = "Additional Mould";
        public const string ToolstampField = "Toolstamp or Mastering Code";

        // Automatic Information

        public const string PVDField = "Primary Volume Descriptor (PVD)";
        public const string DATField = "DAT";
        public const string ErrorCountField = "Error Count";
        public const string CuesheetField = "Cuesheet";
        public const string SubIntentionField = "SubIntention Data (SecuROM/LibCrypt)";
        public const string WriteOffsetField = "Write Offset";
        public const string LayerbreakField = "Layerbreak";
        public const string PlaystationEXEDateField = "EXE Date";
        public const string PlayStationEDCField = "EDC";
        public const string PlayStationAntiModchipField = "Anti-modchip";
        public const string PlayStationLibCryptField = "LibCrypt";
        public const string PlayStation4PICField = "Permanent Information & Control (PIC)";
        public const string SaturnHeaderField = "Header";
        public const string SaturnBuildDateField = "Build Date";
        public const string XBOXDMIHash = "DMI.bin Hashes";
        public const string XBOXPFIHash = "PFI.bin Hashes";
        public const string XBOXSSHash = "SS.bin Hashes";
        public const string XBOXSSRanges = "Security Sector Ranges";
        public const string XBOXSSVersion = "Security Sector Version";

        // Default values

        public const string RequiredValue = "(REQUIRED)";
        public const string RequiredIfExistsValue = "(REQUIRED, IF EXISTS)";
        public const string OptionalValue = "(OPTIONAL)";
        public const string YesNoValue = "Yes/No";
    }
}
