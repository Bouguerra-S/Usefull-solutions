namespace MediaPoint.Subtitles.Logic
{
    // The language classes are build for easy xml-serilization (makes save/load code simple)
    public class LanguageStructure
    {
        public class General
        {
            public string Title { get; set; }
            public string Version { get; set; }
            public string TranslatedBy { get; set; }
            public string CultureName { get; set; }
            public string HelpFile { get; set; }
            public string OK { get; set; }
            public string Cancel { get; set; }
            public string Apply { get; set; }
            public string None { get; set; }
            public string Preview { get; set; }
            public string SubtitleFiles { get; set; }
            public string AllFiles { get; set; }
            public string VideoFiles { get; set; }
            public string OpenSubtitle { get; set; }
            public string OpenVideoFile { get; set; }
            public string OpenVideoFileTitle { get; set; }
            public string NoVideoLoaded { get; set; }
            public string VideoInformation { get; set; }
            public string PositionX { get; set; }
            public string StartTime { get; set; }
            public string EndTime { get; set; }
            public string Duration { get; set; }
            public string NumberSymbol { get; set; }
            public string Number { get; set; }
            public string Text { get; set; }
            public string HourMinutesSecondsMilliseconds { get; set; }
            public string Bold { get; set; }
            public string Italic { get; set; }
            public string Visible { get; set; }
            public string FrameRate { get; set; }
            public string Name { get; set; }
            public string FileNameXAndSize { get; set; }
            public string ResolutionX { get; set; }
            public string FrameRateX { get; set; }
            public string TotalFramesX { get; set; }
            public string VideoEncodingX { get; set; }
            public string SingleLineLengths { get; set; }
            public string TotalLengthX { get; set; }
            public string TotalLengthXSplitLine { get; set; }
            public string SplitLine { get; set; }
            public string NotAvailable { get; set; }
            public string OverlapPreviousLineX { get; set; }
            public string OverlapX { get; set; }
            public string OverlapNextX { get; set; }
            public string Negative { get; set; }
            public string RegularExpressionIsNotValid { get; set; }
            public string SubtitleSaved { get; set; }
            public string CurrentSubtitle { get; set; }
            public string OriginalText { get; set; }
            public string OpenOriginalSubtitleFile { get; set; }
            public string PleaseWait { get; set; }
            public string SessionKey { get; set; }
            public string UserName { get; set; }
            public string UserNameAlreadyInUse { get; set; }
            public string WebServiceUrl { get; set; }
            public string IP { get; set; }
            public string VideoWindowTitle { get; set; }
            public string AudioWindowTitle { get; set; }
            public string ControlsWindowTitle { get; set; }
        }

        public class About
        {
            public string Title { get; set; }
            public string AboutText1 { get; set; }
        }

        public class AddToNames
        {
            public string Title { get; set; }
            public string Description { get; set; }
        }

        public class AddWareForm
        {
            public string Title { get; set; }
            public string SourceVideoFile { get; set; }
            public string GenerateWaveFormData { get; set; }
            public string PleaseWait{ get; set; }
            public string VlcMediaPlayerNotFoundTitle { get; set; }
            public string VlcMediaPlayerNotFound { get; set; }
            public string GoToVlcMediaPlayerHomePage { get; set; }
            public string GeneratingPeakFile { get; set; }
            public string GeneratingSpectrogram { get; set; }
            public string ExtractingSeconds { get; set; }
            public string ExtractingMinutes { get; set; }
        }

        public class AdjustDisplayDuration
        {
            public string Title { get; set; }
            public string AdjustVia { get; set; }
            public string Seconds { get; set; }
            public string Percent { get; set; }
            public string AddSeconds { get; set; }
            public string SetAsPercent { get; set; }
            public string Note { get; set; }
            public string PleaseSelectAValueFromTheDropDownList { get; set; }
            public string PleaseChoose { get; set; }
        }

        public class AutoBreakUnbreakLines
        {
            public string TitleAutoBreak { get; set; }
            public string TitleUnbreak { get; set; }
            public string LineNumber { get; set; }
            public string Before { get; set; }
            public string After { get; set; }
            public string LinesFoundX { get; set; }
            public string OnlyBreakLinesLongerThan { get; set; }
            public string OnlyUnbreakLinesShorterThan { get; set; }
        }

        public class ChangeCasing
        {
            public string Title { get; set; }
            public string ChangeCasingTo { get; set; }
            public string NormalCasing { get; set; }
            public string FixNamesCasing { get; set; }
            public string FixOnlyNamesCasing { get; set; }
            public string OnlyChangeAllUppercaseLines { get; set; }
            public string AllUppercase { get; set; }
            public string AllLowercase { get; set; }
        }

        public class ChangeCasingNames
        {
            public string Title { get; set; }
            public string NamesFoundInSubtitleX { get; set; }
            public string Enabled { get; set; }
            public string Name { get; set; }
            public string LineNumber { get; set; }
            public string Before { get; set; }
            public string After { get; set; }
            public string LinesFoundX { get; set; }
        }

        public class ChangeFrameRate
        {
            public string Title { get; set; }
            public string ConvertFrameRateOfSubtitle { get; set; }
            public string FromFrameRate { get; set; }
            public string ToFrameRate { get; set; }
            public string FrameRateNotCorrect { get; set; }
            public string FrameRateNotChanged { get; set; }
        }

        public class ChooseEncoding
        {
            public string Title { get; set; }
            public string CodePage { get; set; }
            public string DisplayName { get; set; }
            public string PleaseSelectAnEncoding { get; set; }
        }

        public class ChooseLanguage
        {
            public string Title { get; set; }
            public string Language { get; set; }
        }

        public class CompareSubtitles
        {
            public string Title { get; set; }
            public string PreviousDifference { get; set; }
            public string NextDifference { get; set; }
            public string SubtitlesNotAlike { get; set; }
            public string XNumberOfDifference { get; set; }
            public string ShowOnlyDifferences { get; set; }
            public string OnlyLookForDifferencesInText { get; set; }
        }

        public class DvdSubRip
        {
            public string Title { get; set; }
            public string DvdGroupTitle { get; set; }
            public string IfoFile { get; set; }
            public string IfoFiles { get; set; }
            public string VobFiles { get; set; }
            public string Add { get; set; }
            public string Remove { get; set; }
            public string Clear { get; set; }
            public string MoveUp { get; set; }
            public string MoveDown { get; set; }
            public string Languages { get; set; }
            public string PalNtsc { get; set; }
            public string Pal { get; set; }
            public string Ntsc { get; set; }
            public string StartRipping { get; set; }
            public string Abort { get; set; }
            public string AbortedByUser { get; set; }
            public string ReadingSubtitleData { get; set; }
            public string RippingVobFileXofYZ { get; set; }
            public string WrongIfoType { get; set; }
        }

        public class DvdSubRipChooseLanguage
        {
            public string Title { get; set; }
            public string ChooseLanguageStreamId { get; set; }
            public string UnknownLanguage { get; set; }
            public string SubtitleImageXofYAndWidthXHeight { get; set; }
            public string SubtitleImage { get; set; }
        }

        public class EbuSaveOtpions
        {
            public string Title { get; set; }
            public string GeneralSubtitleInformation { get; set; }
            public string CodePageNumber { get; set; }
            public string DiskFormatCode { get; set; }
            public string CharacterCodeTable { get; set; }
            public string LanguageCode { get; set; }
            public string OriginalProgramTitle { get; set; }
            public string OriginalEpisodeTitle { get; set; }
            public string TranslatedProgramTitle { get; set; }
            public string TranslatedEpisodeTitle { get; set; }
            public string TranslatorsName { get; set; }
            public string SubtitleListReferenceCode { get; set; }
            public string CountryOfOrigin { get; set; }
            public string RevisionNumber { get; set; }
            public string MaxNoOfDisplayableChars { get; set; }
            public string MaxNumberOfDisplayableRows { get; set; }
            public string DiskSequenceNumber { get; set; }
            public string TotalNumberOfDisks { get; set; }
            public string Import { get; set; }
            public string TextAndTimingInformation { get; set; }
            public string JustificationCode { get; set; }
            public string Errors { get; set; }
            public string ErrorsX { get; set; }
            public string MaxLengthError { get; set; }
            public string TextUnchangedPresentation { get; set; }
            public string TextLeftJustifiedText { get; set; }
            public string TextCentredText { get; set; }
            public string TextRightJustifiedText { get; set; }
        }

        public class EffectKaraoke
        {
            public string Title { get; set; }
            public string ChooseColor { get; set; }
            public string TotalMilliseconds { get; set; }
            public string EndDelayInMilliseconds { get; set; }
        }

        public class EffectTypewriter
        {
            public string Title { get; set; }
            public string TotalMilliseconds { get; set; }
            public string EndDelayInMillisecs { get; set; }
        }

        public class ExportPngXml
        {
            public string Title { get; set; }
            public string ImageSettings { get; set; }
            public string FontFamily { get; set; }
            public string FontSize { get; set; }
            public string FontColor { get; set; }
            public string BorderColor { get; set; }
            public string BorderWidth { get; set; }
            public string AntiAlias { get; set; }
            public string ExportAllLines { get; set; }
            public string XImagesSavedInY { get; set; }
        }

        public class FindDialog
        {
            public string Title { get; set; }
            public string Find { get; set; }
            public string Normal { get; set; }
            public string CaseSensitive { get; set; }
            public string RegularExpression { get; set; }
        }

        public class FindSubtitleLine
        {
            public string Title { get; set; }
            public string Find { get; set; }
            public string FindNext { get; set; }
        }

        public class FixCommonErrors
        {
            public string Title { get; set; }
            public string Step1 { get; set; }
            public string WhatToFix { get; set; }
            public string Example { get; set; }
            public string SelectAll { get; set; }
            public string InverseSelection { get; set; }
            public string Back { get; set; }
            public string Next { get; set; }
            public string Step2 { get; set; }
            public string Fixes { get; set; }
            public string Log { get; set; }
            public string LineNumber { get; set; }
            public string Function { get; set; }
            public string Before { get; set; }
            public string After { get; set; }
            public string RemovedEmptyLine { get; set; }
            public string RemovedEmptyLineAtTop { get; set; }
            public string RemovedEmptyLineAtBottom { get; set; }
            public string RemovedEmptyLinesUnsedLineBreaks { get; set; }
            public string EmptyLinesRemovedX { get; set; }
            public string FixOverlappingDisplayTimes { get; set; }
            public string FixShortDisplayTimes { get; set; }
            public string FixLongDisplayTimes { get; set; }
            public string FixInvalidItalicTags { get; set; }
            public string RemoveUnneededSpaces { get; set; }
            public string RemoveUnneededPeriods { get; set; }
            public string FixMissingSpaces { get; set; }
            public string BreakLongLines { get; set; }
            public string RemoveLineBreaks { get; set; }
            public string RemoveLineBreaksAll { get; set; }
            public string FixUppercaseIInsindeLowercaseWords { get; set; }
            public string FixDoubleApostrophes { get; set; }
            public string AddPeriods { get; set; }
            public string StartWithUppercaseLetterAfterParagraph { get; set; }
            public string StartWithUppercaseLetterAfterPeriodInsideParagraph { get; set; }
            public string FixLowercaseIToUppercaseI { get; set; }
            public string FixCommonOcrErrors { get; set; }
            public string CommonOcrErrorsFixed { get; set; }
            public string RemoveSpaceBetweenNumber { get; set; }
            public string FixDialogsOnOneLine { get; set; }
            public string RemoveSpaceBetweenNumbersFixed { get; set; }
            public string FixDanishLetterI { get; set; }
            public string FixSpanishInvertedQuestionAndExclamationMarks { get; set; }
            public string AddMissingQuote { get; set; }
            public string AddMissingQuotes { get; set; }
            public string FixHyphens { get; set; }
            public string FixHyphen { get; set; }
            public string XHyphensFixed { get; set; }
            public string AddMissingQuotesExample { get; set; }
            public string XMissingQuotesAdded { get; set; }
            public string Fix3PlusLines { get; set; }
            public string Fix3PlusLine { get; set; }
            public string X3PlusLinesFixed { get; set; }
            public string Analysing { get; set; }
            public string NothingToFix { get; set; }
            public string FixesFoundX { get; set; }
            public string XFixesApplied { get; set; }
            public string NothingToFixBut { get; set; }
            public string FixLowercaseIToUppercaseICheckedButCurrentLanguageIsNotEnglish { get; set; }
            public string Continue { get; set; }
            public string ContinueAnyway { get; set; }
            public string UncheckedFixLowercaseIToUppercaseI { get; set; }
            public string XIsChangedToUppercase { get; set; }
            public string FixFirstLetterToUppercaseAfterParagraph { get; set; }
            public string MergeShortLine { get; set; }
            public string MergeShortLineAll { get; set; }
            public string XLineBreaksAdded { get; set; }
            public string BreakLongLine { get; set; }
            public string FixLongDisplayTime { get; set; }
            public string FixInvalidItalicTag { get; set; }
            public string FixShortDisplayTime { get; set; }
            public string FixOverlappingDisplayTime { get; set; }
            public string FixInvalidItalicTagsExample { get; set; }
            public string RemoveUnneededSpacesExample { get; set; }
            public string RemoveUnneededPeriodsExample { get; set; }
            public string FixMissingSpacesExample { get; set; }
            public string FixUppercaseIInsindeLowercaseWordsExample { get; set; }
            public string FixLowercaseIToUppercaseIExample { get; set; }
            public string StartTimeLaterThanEndTime { get; set; }
            public string UnableToFixStartTimeLaterThanEndTime { get; set; }
            public string XFixedToYZ { get; set; }
            public string UnableToFixTextXY { get; set; }
            public string XOverlappingTimestampsFixed { get; set; }
            public string XDisplayTimesProlonged { get; set; }
            public string XInvalidHtmlTagsFixed  { get; set; }
            public string XDisplayTimesShortned { get; set; }
            public string XLinesUnbreaked { get; set; }
            public string UnneededSpace { get; set; }
            public string XUnneededSpacesRemoved { get; set; }
            public string UnneededPeriod { get; set; }
            public string XUnneededPeriodsRemoved { get; set; }
            public string FixMissingSpace { get; set; }
            public string XMissingSpacesAdded { get; set; }
            public string FixUppercaseIInsideLowercaseWord { get; set; }
            public string XPeriodsAdded { get; set; }
            public string FixMissingPeriodAtEndOfLine { get; set; }
            public string XDoubleApostrophesFixed { get; set; }
            public string XUppercaseIsFoundInsideLowercaseWords { get; set; }
            public string RefreshFixes { get; set; }
            public string ApplyFixes { get; set; }
            public string AutoBreak { get; set; }
            public string Unbreak { get; set; }
            public string FixDoubleDash { get; set; }
            public string FixDoubleGreaterThan { get; set; }
            public string FixEllipsesStart { get; set; }
            public string FixMissingOpenBracket { get; set; }
            public string FixMusicNotation { get; set; }
            public string FixDoubleDashs { get; set; }
            public string FixDoubleGreaterThans { get; set; }
            public string FixEllipsesStarts { get; set; }
            public string FixMissingOpenBrackets { get; set; }
            public string FixMusicNotations { get; set; }
            public string XFixDoubleDash { get; set; }
            public string XFixDoubleGreaterThan { get; set; }
            public string XFixEllipsesStart { get; set; }
            public string XFixMissingOpenBracket { get; set; }
            public string XFixMusicNotation { get; set; }
            public string FixDoubleDashExample { get; set; }
            public string FixDoubleGreaterThanExample { get; set; }
            public string FixEllipsesStartExample { get; set; }
            public string FixMissingOpenBracketExample { get; set; }
            public string FixMusicNotationExample { get; set; }
            public string NumberOfImportantLogMessages { get; set; }
            public string FixedOkXY { get; set; }
        }

        public class GetDictionaries
        {
            public string Title { get; set; }
            public string DescriptionLine1 { get; set; }
            public string DescriptionLine2 { get; set; }
            public string GetDictionariesHere { get; set; }
            public string OpenOpenOfficeWiki { get; set; }
            public string GetAllDictionaries { get; set; }
            public string ChooseLanguageAndClickDownload { get; set; }
            public string OpenDictionariesFolder { get; set; }
            public string Download { get; set; }
            public string XDownloaded { get; set; }
        }

        public class GoogleTranslate
        {
            public string Title { get; set; }
            public string From { get; set; }
            public string To { get; set; }
            public string Translate { get; set; }
            public string PleaseWait { get; set; }
            public string PoweredByGoogleTranslate { get; set; }
            public string PoweredByMicrosoftTranslate { get; set; }
        }

        public class GoogleOrMicrosoftTranslate
        {
            public string Title { get; set; }
            public string From { get; set; }
            public string To { get; set; }
            public string Translate { get; set; }
            public string SourceText { get; set; }
            public string GoogleTranslate { get; set; }
            public string MicrosoftTranslate { get; set; }
        }

        public class GoToLine
        {
            public string Title { get; set; }
            public string XIsNotAValidNumber { get; set; }
        }

        public class ImportText
        {
            public string Title { get; set; }
            public string OpenTextFile { get; set; }
            public string ImportOptions { get; set; }
            public string Splitting { get; set; }
            public string AutoSplitText { get; set; }
            public string OneLineIsOneSubtitle { get; set; }
            public string MergeShortLines { get; set; }
            public string RemoveEmptyLines { get; set; }
            public string RemoveLinesWithoutLetters { get; set; }
            public string GapBetweenSubtitles { get; set; }
            public string Auto { get; set; }
            public string Fixed { get; set; }
            public string Refresh { get; set; }
            public string Next { get; set; }
            public string TextFiles { get; set; }
            public string PreviewLinesModifiedX { get; set; }
        }

        public class Interjections
        {
            public string Title { get; set; }
        }

        public class Main
        {
            public MainMenu Menu { get; set; }
            public MainControls Controls { get; set; }
            public MainVideoControls VideoControls { get; set; }
            public string SaveChangesToUntitled { get; set; }
            public string SaveChangesToX { get; set; }
            public string SaveChangesToUntitledOriginal { get; set; }
            public string SaveChangesToOriginalX { get; set; }
            public string SaveSubtitleAs { get; set; }
            public string SaveOriginalSubtitleAs { get; set; }
            public string NoSubtitleLoaded { get; set; }
            public string VisualSyncSelectedLines { get; set; }
            public string VisualSyncTitle { get; set; }
            public string BeforeVisualSync { get; set; }
            public string VisualSyncPerformedOnSelectedLines { get; set; }
            public string VisualSyncPerformed { get; set; }
            public string ImportThisVobSubSubtitle { get; set; }
            public string FileXIsLargerThan10Mb { get; set; }
            public string ContinueAnyway { get; set; }
            public string BeforeLoadOf { get; set; }
            public string LoadedSubtitleX { get; set; }
            public string LoadedEmptyOrShort { get; set; }
            public string FileIsEmptyOrShort { get; set; }
            public string FileNotFound { get; set; }
            public string SavedSubtitleX { get; set; }
            public string SavedOriginalSubtitleX { get; set; }
            public string FileOnDiskModified { get; set; }
            public string OverwriteModifiedFile { get; set; }
            public string UnableToSaveSubtitleX { get; set; }
            public string BeforeNew { get; set; }
            public string New { get; set; }
            public string BeforeConvertingToX { get; set; }
            public string ConvertedToX { get; set; }
            public string BeforeShowEarlier { get; set; }
            public string BeforeShowLater { get; set; }
            public string LineNumberX { get; set; }
            public string OpenVideoFile { get; set; }
            public string NewFrameRateUsedToCalculateTimeCodes { get; set; }
            public string NewFrameRateUsedToCalculateFrameNumbers { get; set; }
            public string FindContinue { get; set; }
            public string FindContinueTitle { get; set; }
            public string XFoundAtLineNumberY { get; set; }
            public string XNotFound { get; set; }
            public string BeforeReplace { get; set; }
            public string MatchFoundX { get; set; }
            public string NoMatchFoundX { get; set; }
            public string FoundNothingToReplace { get; set; }
            public string ReplaceCountX { get; set; }
            public string NoXFoundAtLineY { get; set; }
            public string OneReplacementMade { get; set; }
            public string BeforeChangesMadeInSourceView { get; set; }
            public string UnableToParseSourceView { get; set; }
            public string GoToLineNumberX { get; set; }
            public string CreateAdjustChangesApplied { get; set; }
            public string SelectedLines { get; set; }
            public string BeforeDisplayTimeAdjustment { get; set; }
            public string DisplayTimeAdjustedX { get; set; }
            public string DisplayTimesAdjustedX { get; set; }
            public string StarTimeAdjustedX { get; set; }
            public string BeforeCommonErrorFixes { get; set; }
            public string CommonErrorsFixedInSelectedLines { get; set; }
            public string CommonErrorsFixed { get; set; }
            public string BeforeRenumbering { get; set; }
            public string RenumberedStartingFromX { get; set; }
            public string BeforeRemovalOfTextingForHearingImpaired { get; set; }
            public string TextingForHearingImpairedRemovedOneLine { get; set; }
            public string TextingForHearingImpairedRemovedXLines { get; set; }
            public string SubtitleSplitted { get; set; }
            public string SubtitleAppendPrompt { get; set; }
            public string SubtitleAppendPromptTitle { get; set; }
            public string OpenSubtitleToAppend { get; set; }
            public string AppendViaVisualSyncTitle { get; set; }
            public string AppendSynchronizedSubtitlePrompt { get; set; }
            public string BeforeAppend { get; set; }
            public string SubtitleAppendedX { get; set; }
            public string SubtitleNotAppended { get; set; }
            public string GoogleTranslate { get; set; }
            public string MicrosoftTranslate { get; set; }
            public string BeforeGoogleTranslation { get; set; }
            public string SelectedLinesTranslated { get; set; }
            public string SubtitleTranslated { get; set; }
            public string TranslateSwedishToDanish { get; set; }
            public string TranslateSwedishToDanishWarning { get; set; }
            public string TranslatingViaNikseDkMt { get; set; }
            public string BeforeSwedishToDanishTranslation { get; set; }
            public string TranslationFromSwedishToDanishComplete { get; set; }
            public string TranslationFromSwedishToDanishFailed { get; set; }
            public string BeforeUndo { get; set; }
            public string UndoPerformed { get; set; }
            public string NothingToUndo { get; set; }
            public string InvalidLanguageNameX { get; set; }
            public string UnableToChangeLanguage { get; set; }
            public string NumberOfCorrectedWords { get; set; }
            public string NumberOfSkippedWords { get; set; }
            public string NumberOfCorrectWords { get; set; }
            public string NumberOfWordsAddedToDictionary { get; set; }
            public string NumberOfNameHits { get; set; }
            public string SpellCheck { get; set; }
            public string BeforeSpellCheck { get; set; }
            public string SpellCheckChangedXToY { get; set; }
            public string BeforeAddingTagX { get; set; }
            public string TagXAdded { get; set; }
            public string LineXOfY { get; set; }
            public string XLinesDeleted { get; set; }
            public string BeforeDeletingXLines { get; set; }
            public string DeleteXLinesPrompt { get; set; }
            public string OneLineDeleted { get; set; }
            public string BeforeDeletingOneLine { get; set; }
            public string DeleteOneLinePrompt { get; set; }
            public string BeforeInsertLine { get; set; }
            public string LineInserted { get; set; }
            public string BeforeLineUpdatedInListView { get; set; }
            public string BeforeSettingFontToNormal { get; set; }
            public string BeforeSplitLine { get; set; }
            public string LineSplitted { get; set; }
            public string BeforeMergeLines { get; set; }
            public string LinesMerged { get; set; }
            public string BeforeSettingColor { get; set; }
            public string BeforeSettingFontName { get; set; }
            public string BeforeTypeWriterEffect { get; set; }
            public string BeforeKaraokeEffect { get; set; }
            public string BeforeImportingDvdSubtitle { get; set; }
            public string OpenMatroskaFile { get; set; }
            public string MatroskaFiles { get; set; }
            public string NoSubtitlesFound { get; set; }
            public string NotAValidMatroskaFileX { get; set; }
            public string ParsingMatroskaFile { get; set; }
            public string BeforeImportFromMatroskaFile { get; set; }
            public string SubtitleImportedFromMatroskaFile { get; set; }
            public string DropFileXNotAccepted { get; set; }
            public string DropOnlyOneFile { get; set; }
            public string BeforeCreateAdjustLines { get; set; }
            public string OpenAnsiSubtitle { get; set; }
            public string BeforeChangeCasing { get; set; }
            public string CasingCompleteMessageNoNames { get; set; }
            public string CasingCompleteMessageOnlyNames { get; set; }
            public string CasingCompleteMessage { get; set; }
            public string BeforeChangeFrameRate { get; set; }
            public string FrameRateChangedFromXToY { get; set; }
            public string IdxFileNotFoundWarning { get; set; }
            public string InvalidVobSubHeader { get; set; }
            public string OpenVobSubFile { get; set; }
            public string VobSubFiles { get; set; }
            public string OpenBluRaySupFile { get; set; }
            public string BluRaySupFiles { get; set; }
            public string BeforeImportingVobSubFile { get; set; }
            public string BeforeImportingBluRaySupFile { get; set; }
            public string BeforeImportingBdnXml { get; set; }
            public string BeforeShowSelectedLinesEarlierLater { get; set; }
            public string ShowSelectedLinesEarlierLaterPerformed { get; set; }
            public string DoubleWordsViaRegEx { get; set; }
            public string BeforeSortX { get; set; }
            public string SortedByX { get; set; }
            public string BeforeAutoBalanceSelectedLines { get; set; }
            public string NumberOfLinesAutoBalancedX { get; set; }
            public string BeforeRemoveLineBreaksInSelectedLines { get; set; }
            public string NumberOfWithRemovedLineBreakX { get; set; }
            public string BeforeMultipleReplace { get; set; }
            public string NumberOfLinesReplacedX { get; set; }
            public string NameXAddedToNamesEtcList { get; set; }
            public string NameXNotAddedToNamesEtcList { get; set; }
            public string XLinesSelected { get; set; }
            public string UnicodeMusicSymbolsAnsiWarning { get; set; }
            public string NegativeTimeWarning { get; set; }
            public string BeforeMergeShortLines { get; set; }
            public string BeforeSplitLongLines { get; set; }
            public string MergedShortLinesX { get; set; }
            public string BeforeSetMinimumDisplayTimeBetweenParagraphs { get; set; }
            public string XMinimumDisplayTimeBetweenParagraphsChanged { get; set; }
            public string BeforeImportText { get; set; }
            public string TextImported { get; set; }
            public string BeforePointSynchronization { get; set; }
            public string PointSynchronizationDone { get; set; }
            public string BeforeTimeCodeImport { get; set; }
            public string TimeCodeImportedFromXY { get; set; }
            public string BeforeInsertSubtitleAtVideoPosition { get; set; }
            public string BeforeSetStartTimeAndOffsetTheRest { get; set; }
            public string BeforeSetEndAndVideoPosition { get; set; }
            public string ContinueWithCurrentSpellCheck { get; set; }
            public string CharactersPerSecond { get; set; }
            public string GetFrameRateFromVideoFile { get; set; }
            public string NetworkMessage { get; set; }
            public string NetworkUpdate { get; set; }
            public string NetworkInsert { get; set; }
            public string NetworkDelete { get; set; }
            public string NetworkNewUser { get; set; }
            public string NetworkByeUser { get; set; }
            public string NetworkUnableToConnectToServer { get; set; }
            public string UserAndAction { get; set; }
            public string NetworkMode { get; set; }
            public string XStartedSessionYAtZ { get; set; }
            public string SpellChekingViaWordXLineYOfX { get; set; }
            public string UnableToStartWord { get; set; }
            public string SpellCheckAbortedXCorrections { get; set; }
            public string SpellCheckCompletedXCorrections { get; set; }
            public string OpenOtherSubtitle { get; set; }
            public string BeforeToggleDialogueDashes { get; set; }
            public string ExportPlainTextAs { get; set; }
            public string TextFiles { get; set; }

            public class MainMenu
            {
                public class FileMenu
                {
                    public string Title { get; set; }
                    public string New { get; set; }
                    public string Open { get; set; }
                    public string Reopen { get; set; }
                    public string Save { get; set; }
                    public string SaveAs { get; set; }
                    public string OpenOriginal { get; set; }
                    public string SaveOriginal { get; set; }
                    public string CloseOriginal { get; set; }
                    public string OpenContainingFolder { get; set; }
                    public string Compare { get; set; }
                    public string ImportOcrFromDvd { get; set; }
                    public string ImportOcrVobSubSubtitle { get; set; }
                    public string ImportBluRaySupFile { get; set; }
                    public string ImportSubtitleFromMatroskaFile { get; set; }
                    public string ImportSubtitleWithManualChosenEncoding { get; set; }
                    public string ImportText { get; set; }
                    public string ImportTimecodes { get; set; }
                    public string Export { get; set; }
                    public string ExportBdnXml { get; set; }
                    public string ExportBluRaySup { get; set; }
                    public string ExportVobSub { get; set; }
                    public string ExportCavena890 { get; set; }
                    public string ExportEbu { get; set; }
                    public string ExportPac { get; set; }
                    public string ExportPlainText { get; set; }
                    public string ExportPlainTextWithoutLineBreaks { get; set; }
                    public string Exit { get; set; }
                }
                public class EditMenu
                {
                    public string Title { get; set; }
                    public string ShowUndoHistory { get; set; }
                    public string InsertUnicodeSymbol { get; set; }
                    public string Find { get; set; }
                    public string FindNext { get; set; }
                    public string Replace { get; set; }
                    public string MultipleReplace { get; set; }
                    public string GoToSubtitleNumber { get; set; }
                }
                public class ToolsMenu
                {
                    public string Title { get; set; }
                    public string AdjustDisplayDuration { get; set; }
                    public string FixCommonErrors { get; set; }
                    public string StartNumberingFrom { get; set; }
                    public string RemoveTextForHearingImpaired { get; set; }
                    public string ChangeCasing { get; set; }
                    public string ChangeFrameRate { get; set; }
                    public string MergeShortLines { get; set; }
                    public string SplitLongLines { get; set; }
                    public string MinimumDisplayTimeBetweenParagraphs { get; set; }
                    public string SortBy { get; set; }
                    public string Number { get; set; }
                    public string StartTime { get; set; }
                    public string EndTime { get; set; }
                    public string Duration { get; set; }
                    public string TextAlphabetically { get; set; }
                    public string TextSingleLineMaximumLength { get; set; }
                    public string TextTotalLength { get; set; }
                    public string TextNumberOfLines { get; set; }
                    public string TextNumberOfCharactersPerSeconds { get; set; }
                    public string ShowOriginalTextInAudioAndVideoPreview { get; set; }
                    public string MakeNewEmptyTranslationFromCurrentSubtitle { get; set; }
                    public string SplitSubtitle { get; set; }
                    public string AppendSubtitle { get; set; }
                }
                public class VideoMenu
                {
                    public string Title { get; set; }
                    public string OpenVideo { get; set; }
                    public string ChooseAudioTrack { get; set; }
                    public string CloseVideo { get; set; }
                    public string ShowHideVideo { get; set; }
                    public string ShowHideWaveForm { get; set; }
                    public string ShowHideWaveformAndSpectrogram { get; set; }
                    public string UnDockVideoControls { get; set; }
                    public string ReDockVideoControls { get; set; }
                }
                public class SpellCheckMenu
                {
                    public string Title { get; set; }
                    public string SpellCheck { get; set; }
                    public string FindDoubleWords { get; set; }
                    public string FindDoubleLines { get; set; }
                    public string GetDictionaries { get; set; }
                    public string AddToNamesEtcList { get; set; }
                }
                public class SynchronizationkMenu
                {
                    public string Title { get; set; }
                    public string AdjustAllTimes { get; set; }
                    public string VisualSync { get; set; }
                    public string PointSync { get; set; }
                    public string PointSyncViaOtherSubtitle { get; set; }
                }
                public class AutoTranslateMenu
                {
                    public string Title { get; set; }
                    public string TranslatePoweredByGoogle { get; set; }
                    public string TranslatePoweredByMicrosoft { get; set; }
                    public string TranslateFromSwedishToDanish { get; set; }
                }
                public class OptionsMenu
                {
                    public string Title { get; set; }
                    public string Settings { get; set; }
                    public string ChooseLanguage { get; set; }
                }

                public class NetworkingMenu
                {
                    public string Title { get; set; }
                    public string StartNewSession { get; set; }
                    public string JoinSession { get; set; }
                    public string ShowSessionInfoAndLog { get; set; }
                    public string Chat { get; set; }
                    public string LeaveSession { get; set; }
                }

                public class HelpMenu
                {
                    public string Title { get; set; }
                    public string Help { get; set; }
                    public string About { get; set; }
                }

                public class ToolBarMenu
                {
                    public string New { get; set; }
                    public string Open { get; set; }
                    public string Save { get; set; }
                    public string SaveAs { get; set; }
                    public string Find { get; set; }
                    public string Replace { get; set; }
                    public string VisualSync { get; set; }
                    public string SpellCheck { get; set; }
                    public string Settings { get; set; }
                    public string Help { get; set; }
                    public string ShowHideWaveForm { get; set; }
                    public string ShowHideVideo { get; set; }
                }

                public class ListViewContextMenu
                {
                    public string SubStationAlphaSetStyle { get; set; }
                    public string Cut { get; set; }
                    public string Copy { get; set; }
                    public string Paste { get; set; }
                    public string Delete { get; set; }
                    public string SplitLineAtCursorPosition { get; set; }
                    public string SelectAll { get; set; }
                    public string InsertFirstLine { get; set; }
                    public string InsertBefore { get; set; }
                    public string InsertAfter { get; set; }
                    public string InsertSubtitleAfter { get; set; }
                    public string CopyToClipboard { get; set; }
                    public string Split { get; set; }
                    public string MergeSelectedLines { get; set; }
                    public string MergeWithLineBefore { get; set; }
                    public string MergeWithLineAfter { get; set; }
                    public string Normal { get; set; }
                    public string Underline { get; set; }
                    public string Color { get; set; }
                    public string FontName { get; set; }
                    public string AutoBalanceSelectedLines { get; set; }
                    public string RemoveLineBreaksFromSelectedLines { get; set; }
                    public string TypewriterEffect { get; set; }
                    public string KaraokeEffect { get; set; }
                    public string ShowSelectedLinesEarlierLater { get; set; }
                    public string VisualSyncSelectedLines { get; set; }
                    public string GoogleAndMicrosoftTranslateSelectedLine { get; set; }
                    public string GoogleTranslateSelectedLines { get; set; }
                    public string AdjustDisplayDurationForSelectedLines { get; set; }
                    public string FixCommonErrorsInSelectedLines { get; set; }
                    public string ChangeCasingForSelectedLines { get; set; }
                }

                public FileMenu File { get; set; }
                public EditMenu Edit { get; set; }
                public ToolsMenu Tools { get; set; }
                public VideoMenu Video { get; set; }
                public SpellCheckMenu SpellCheck { get; set; }
                public SynchronizationkMenu Synchronization { get; set; }
                public AutoTranslateMenu AutoTranslate { get; set; }
                public OptionsMenu Options { get; set; }
                public NetworkingMenu Networking { get; set; }
                public HelpMenu Help { get; set; }
                public ToolBarMenu ToolBar { get; set; }
                public ListViewContextMenu ContextMenu { get; set; }
            }

            public class MainControls
            {
                public string SubtitleFormat { get; set; }
                public string FileEncoding { get; set; }
                public string ListView { get; set; }
                public string SourceView { get; set; }
                public string UndoChangesInEditPanel { get; set; }
                public string Previous { get; set; }
                public string Next { get; set; }
                public string AutoBreak { get; set; }
                public string Unbreak { get; set; }
            }

            public class MainVideoControls
            {
                public string Translate { get; set; }
                public string Create { get; set; }
                public string Adjust { get; set; }
                public string SelectCurrentElementWhilePlaying { get; set; }

                //translation helper
                public string AutoRepeat { get; set; }
                public string AutoRepeatOn { get; set; }
                public string AutoRepeatCount { get; set; }
                public string AutoContinue { get; set; }
                public string AutoContinueOn { get; set; }
                public string DelayInSeconds { get; set; }
                public string OriginalText { get; set; }
                public string Previous { get; set; }
                public string Stop { get; set; }
                public string PlayCurrent { get; set; }
                public string Next { get; set; }
                public string Playing { get; set; }
                public string RepeatingLastTime { get; set; }
                public string RepeatingXTimesLeft { get; set; }
                public string AutoContinueInOneSecond { get; set; }
                public string AutoContinueInXSeconds { get; set; }
                public string StillTypingAutoContinueStopped { get; set; }

                // create/adjust
                public string InsertNewSubtitleAtVideoPosition { get; set; }
                public string Auto { get; set; }
                public string PlayFromJustBeforeText { get; set; }
                public string Pause { get; set; }
                public string GoToSubtitlePositionAndPause { get; set; }
                public string SetStartTime { get; set; }
                public string SetEndTimeAndGoToNext { get; set; }
                public string AdjustedViaEndTime { get; set; }
                public string SetEndTime { get; set; }
                public string SetstartTimeAndOffsetOfRest { get; set; }

                public string SearchTextOnline { get; set; }
                public string GoogleTranslate { get; set; }
                public string GoogleIt { get; set; }
                public string SecondsBackShort { get; set; }
                public string SecondsForwardShort { get; set; }
                public string VideoPosition { get; set; }
                public string TranslateTip { get; set; }
                public string CreateTip { get; set; }
                public string AdjustTip { get; set; }

                public string BeforeChangingTimeInWaveFormX { get; set; }
                public string NewTextInsertAtX { get; set; }

                public string Center { get; set; }
                public string PlayRate { get; set; }
                public string Slow { get; set; }
                public string Normal { get; set; }
                public string Fast { get; set; }
                public string VeryFast { get; set; }
            }

        }

        public class MatroskaSubtitleChooser
        {
            public string Title { get; set; }
            public string PleaseChoose { get; set; }
            public string TrackXLanguageYTypeZ { get; set; }
        }

        public class MergeShortLines
        {
            public string Title { get; set; }
            public string MaximumCharacters { get; set; }
            public string MaximumMillisecondsBetween { get; set; }
            public string NumberOfMergesX { get; set; }
            public string LineNumber { get; set; }
            public string MergedText { get; set; }
            public string OnlyMergeContinuationLines { get; set; }
        }

        public class MultipleReplace
        {
            public string Title { get; set; }
            public string FindWhat { get; set; }
            public string ReplaceWith { get; set; }
            public string Normal { get; set; }
            public string CaseSensitive { get; set; }
            public string RegularExpression { get; set; }
            public string LineNumber { get; set; }
            public string Before { get; set; }
            public string After { get; set; }
            public string LinesFoundX { get; set; }
            public string Delete { get; set; }
            public string Add { get; set; }
            public string Update { get; set; }
            public string Enabled { get; set; }
            public string SearchType { get; set; }
        }

        public class NetworkChat
        {
            public string Title { get; set; }
            public string Send { get; set; }
        }

        public class NetworkJoin
        {
            public string Title { get; set; }
            public string Information { get; set; }
            public string Join { get; set; }
        }

        public class NetworkLogAndInfo
        {
            public string Title { get; set; }
            public string Log { get; set; }
        }

        public class NetworkStart
        {
            public string Title { get; set; }
            public string ConnectionTo { get; set; }
            public string Information { get; set; }
            public string Start { get; set; }
        }

        public class RemoveTextFromHearImpaired
        {
            public string Title { get; set; }
            public string RemoveTextConditions { get; set; }
            public string RemoveTextBetween { get; set; }
            public string SquareBrackets { get; set; }
            public string Brackets { get; set; }
            public string Parentheses { get; set; }
            public string QuestionMarks { get; set; }
            public string And { get; set; }
            public string RemoveTextBeforeColon { get; set; }
            public string OnlyIfTextIsUppercase { get; set; }
            public string OnlyIfInSeparateLine { get; set; }
            public string LineNumber { get; set; }
            public string Before { get; set; }
            public string After { get; set; }
            public string LinesFoundX { get; set; }
            public string RemoveTextIfContains { get; set; }
            public string RemoveInterjections { get; set; }
            public string EditInterjections { get; set; }
        }

        public class ReplaceDialog
        {
            public string Title { get; set; }
            public string FindWhat { get; set; }
            public string Normal { get; set; }
            public string CaseSensitive { get; set; }
            public string RegularExpression { get; set; }
            public string ReplaceWith { get; set; }
            public string Find { get; set; }
            public string Replace { get; set; }
            public string ReplaceAll { get; set; }
        }

        public class SetMinimumDisplayTimeBetweenParagraphs
        {
            public string Title { get; set; }
            public string PreviewLinesModifiedX { get; set; }
            public string ShowOnlyModifiedLines { get; set; }
            public string MinimumMillisecondsBetweenParagraphs { get; set; }
        }

        public class SetSyncPoint
        {
            public string Title { get; set; }
            public string SyncPointTimeCode { get; set; }
            public string ThreeSecondsBack { get; set; }
            public string HalfASecondBack { get; set; }
            public string HalfASecondForward { get; set; }
            public string ThreeSecondsForward { get; set; }
        }

        public class Settings
        {
            public string Title { get; set; }
            public string General { get; set; }
            public string Toolbar { get; set; }
            public string VideoPlayer { get; set; }
            public string WaveformAndSpectrogram { get; set; }
            public string Tools { get; set; }
            public string WordLists { get; set; }
            public string SsaStyle { get; set; }
            public string Proxy { get; set; }
            public string ShowToolBarButtons { get; set; }
            public string New { get; set; }
            public string Open { get; set; }
            public string Save { get; set; }
            public string SaveAs { get; set; }
            public string Find { get; set; }
            public string Replace { get; set; }
            public string VisualSync { get; set; }
            public string SpellCheck { get; set; }
            public string SettingsName { get; set; }
            public string Help { get; set; }
            public string ShowFrameRate { get; set; }
            public string DefaultFrameRate { get; set; }
            public string DefaultFileEncoding { get; set; }
            public string AutoDetectAnsiEncoding { get; set; }
            public string SubtitleLineMaximumLength { get; set; }
            public string AutoWrapWhileTyping { get; set; }
            public string SubtitleFont { get; set; }
            public string SubtitleFontSize { get; set; }
            public string SubtitleBold { get; set; }
            public string SubtitleFontColor { get; set; }
            public string SubtitleBackgroundColor { get; set; }
            public string SpellChecker { get; set; }
            public string RememberRecentFiles { get; set; }
            public string StartWithLastFileLoaded { get; set; }
            public string RememberSelectedLine { get; set; }
            public string RememberPositionAndSize { get; set; }
            public string StartInSourceView { get; set; }
            public string RemoveBlankLinesWhenOpening { get; set; }
            public string ShowLineBreaksAs { get; set; }
            public string MainListViewDoubleClickAction { get; set; }
            public string MainListViewNothing { get; set; }
            public string MainListViewVideoGoToPositionAndPause { get; set; }
            public string MainListViewVideoGoToPositionAndPlay { get; set; }
            public string MainListViewEditText { get; set; }
            public string AutoBackup { get; set; }
            public string AutoBackupEveryMinute { get; set; }
            public string AutoBackupEveryFiveMinutes { get; set; }
            public string AutoBackupEveryFifteenMinutes { get; set; }
            public string AllowEditOfOriginalSubtitle { get; set; }
            public string PromptDeleteLines { get; set; }
            public string VideoEngine { get; set; }
            public string DirectShow { get; set; }
            public string DirectShowDescription { get; set; }
            public string ManagedDirectX { get; set; }
            public string ManagedDirectXDescription { get; set; }
            public string MPlayer { get; set; }
            public string MPlayerDescription { get; set; }
            public string VlcMediaPlayer { get; set; }
            public string VlcMediaPlayerDescription { get; set; }
            public string ShowStopButton { get; set; }
            public string DefaultVolume { get; set; }
            public string VolumeNotes { get; set; }
            public string PreviewFontSize { get; set; }
            public string MainWindowVideoControls { get; set; }
            public string CustomSearchTextAndUrl { get; set; }
            public string WaveFormAppearance { get; set; }
            public string WaveFormGridColor { get; set; }
            public string WaveFormShowGridLines { get; set; }
            public string ReverseMouseWheelScrollDirection { get; set; }
            public string WaveFormColor { get; set; }
            public string WaveFormSelectedColor { get; set; }
            public string WaveFormBackgroundColor { get; set; }
            public string WaveFormTextColor { get; set; }
            public string WaveformAndSpectrogramsFolderEmpty { get; set; }
            public string WaveformAndSpectrogramsFolderInfo { get; set; }
            public string Spectrogram { get; set; }
            public string GenerateSpectrogram { get; set; }
            public string SpectrogramAppearance { get; set; }
            public string SpectrogramOneColorGradient { get; set; }
            public string SpectrogramClassic { get; set; }
            public string SubStationAlphaStyle { get; set; }
            public string ChooseFont { get; set; }
            public string ChooseColor { get; set; }
            public string Example { get; set; }
            public string Testing123 { get; set; }
            public string Language { get; set; }
            public string NamesIgnoreLists { get; set; }
            public string AddNameEtc { get; set; }
            public string AddWord { get; set; }
            public string Remove { get; set; }
            public string AddPair { get; set; }
            public string UserWordList { get; set; }
            public string OcrFixList { get; set; }
            public string Location { get; set; }
            public string UseOnlineNamesEtc { get; set; }
            public string WordAddedX { get; set; }
            public string WordAlreadyExists { get; set; }
            public string WordNotFound { get; set; }
            public string RemoveX { get; set; }
            public string CannotUpdateNamesEtcOnline { get; set; }
            public string ProxyServerSettings { get; set; }
            public string ProxyAddress { get; set; }
            public string ProxyAuthentication { get; set; }
            public string ProxyUserName { get; set; }
            public string ProxyPassword { get; set; }
            public string ProxyDomain { get; set; }
            public string PlayXSecondsAndBack { get; set; }
            public string StartSceneIndex { get; set; }
            public string EndSceneIndex { get; set; }
            public string FirstPlusX { get; set; }
            public string LastMinusX { get; set; }
            public string FixCommonerrors { get; set; }
            public string MergeLinesShorterThan { get; set; }
            public string MusicSymbol { get; set; }
            public string MusicSymbolsToReplace { get; set; }
            public string FixCommonOcrErrorsUseHardcodedRules { get; set; }
            public string Shortcuts { get; set; }
            public string Shortcut { get; set; }
            public string Control { get; set; }
            public string Alt { get; set; }
            public string Shift { get; set; }
            public string Key { get; set; }
            public string TextBox { get; set; }
            public string UpdateShortcut { get; set; }
            public string ShortcutIsNotValid { get; set; }
            public string ToggleDockUndockOfVideoControls { get; set; }
            public string AdjustViaEndAutoStartAndGoToNext { get; set; }
            public string AdjustSetStartAutoDurationAndGoToNext { get; set; }
            public string AdjustSelected100MsForward { get; set; }
            public string AdjustSelected100MsBack { get; set; }
            public string GoToNext { get; set; }
            public string GoToPrevious { get; set; }
            public string ToggleDialogueDashes { get; set; }
            public string VerticalZoom { get; set; }
            public string WaveformSeekSilenceForward { get; set; }
            public string WaveformSeekSilenceBack { get; set; }
            public string GoBack100Milliseconds { get; set; }
            public string GoForward100Milliseconds { get; set; }
            public string GoBack500Milliseconds { get; set; }
            public string GoForward500Milliseconds { get; set; }
            public string Fullscreen { get; set; }
        }

        public class ShowEarlierLater
        {
            public string Title { get; set; }
            public string TitleAll { get; set; }
            public string ShowEarlier { get; set; }
            public string ShowLater { get; set; }
            public string TotalAdjustmentX { get; set; }
            public string AllLines { get; set; }
            public string SelectedLinesonly { get; set; }
        }

        public class ShowHistory
        {
            public string Title { get; set; }
            public string SelectRollbackPoint { get; set; }
            public string Time { get; set; }
            public string Description { get; set; }
            public string CompareHistoryItems { get; set; }
            public string CompareWithCurrent { get; set; }
            public string Rollback { get; set; }
        }

        public class SpellCheck
        {
            public string Title { get; set; }
            public string FullText { get; set; }
            public string WordNotFound { get; set; }
            public string Language { get; set; }
            public string Change { get; set; }
            public string ChangeAll { get; set; }
            public string SkipOnce { get; set; }
            public string SkipAll { get; set; }
            public string AddToUserDictionary { get; set; }
            public string AddToNamesAndIgnoreList { get; set; }
            public string Abort { get; set; }
            public string Use { get; set; }
            public string UseAlways { get; set; }
            public string Suggestions { get; set; }
            public string SpellCheckProgress { get; set; }
            public string EditWholeText { get; set; }
            public string EditWordOnly { get; set; }
            public string AddXToNamesEtc { get; set; }
            public string AutoFixNames { get; set; }
            public string ImageText { get; set; }
            public string SpellCheckCompleted { get; set; }
            public string SpellCheckAborted { get; set; }
        }

        public class SplitLongLines
        {
            public string Title { get; set; }
            public string SingleLineMaximumLength { get; set; }
            public string LineMaximumLength { get; set; }
            public string LineContinuationBeginEndStrings { get; set; }
            public string NumberOfSplits { get; set; }
            public string LongestSingleLineIsXAtY { get; set; }
            public string LongestLineIsXAtY { get; set; }
        }

        public class SplitSubtitle
        {
            public string Title { get; set; }
            public string Description1 { get; set; }
            public string Description2 { get; set; }
            public string Split { get; set; }
            public string Done { get; set; }
            public string NothingToSplit { get; set; }
            public string SavePartOneAs { get; set; }
            public string SavePartTwoAs{ get; set; }
            public string Part1 { get; set; }
            public string Part2 { get; set; }
            public string UnableToSaveFileX { get; set; }
        }

        public class StartNumberingFrom
        {
            public string Title { get; set; }
            public string StartFromNumber { get; set; }
            public string PleaseEnterAValidNumber { get; set; }
        }

        public class PointSync
        {
            public string Title { get; set; }
            public string TitleViaOtherSubtitle { get; set; }
            public string SyncHelp { get; set; }
            public string SetSyncPoint { get; set; }
            public string RemoveSyncPoint { get; set; }
            public string SyncPointsX { get; set; }
            public string Info { get; set; }
            public string ApplySync { get; set; }
        }

        public class UnknownSubtitle
        {
            public string Title { get; set; }
            public string Message { get; set; }
        }

        public class VisualSync
        {
            public string Title { get; set; }
            public string StartScene { get; set; }
            public string EndScene { get; set; }
            public string Synchronize { get; set; }
            public string HalfASecondBack { get; set; }
            public string ThreeSecondsBack { get; set; }
            public string PlayXSecondsAndBack { get; set; }
            public string FindText { get; set; }
            public string GoToSubPosition { get; set; }
            public string KeepChangesTitle { get; set; }
            public string KeepChangesMessage { get; set; }
            public string SynchronizationDone { get; set; }
            public string StartSceneMustComeBeforeEndScene { get; set; }
            public string Tip { get; set; }
        }

        public class VobSubEditCharacters
        {
            public string Title { get; set; }
            public string ChooseCharacter { get; set; }
            public string ImageCompareFiles { get; set; }
            public string CurrentCompareImage { get; set; }
            public string TextAssociatedWithImage { get; set; }
            public string IsItalic { get; set; }
            public string Update { get; set; }
            public string Delete { get; set; }
            public string ImageDoubleSize { get; set; }
            public string ImageFileNotFound { get; set; }
            public string Image { get; set; }
        }

        public class VobSubOcr
        {
            public string Title { get; set; }
            public string TitleBluRay { get; set; }
            public string OcrMethod { get; set; }
            public string OcrViaModi { get; set; }
            public string OcrViaTesseract { get; set; }
            public string Language { get; set; }
            public string OcrViaImageCompare { get; set; }
            public string ImageDatabase { get; set; }
            public string NoOfPixelsIsSpace { get; set; }
            public string New { get; set; }
            public string Edit { get; set; }
            public string StartOcr { get; set; }
            public string Stop { get; set; }
            public string StartOcrFrom { get; set; }
            public string LoadingVobSubImages { get; set; }
            public string SubtitleImage { get; set; }
            public string SubtitleText { get; set; }
            public string UnableToCreateCharacterDatabaseFolder { get; set; }
            public string SubtitleImageXofY { get; set; }
            public string ImagePalette { get; set; }
            public string UseCustomColors { get; set; }
            public string Transparent { get; set; }
            public string PromptForUnknownWords { get; set; }
            public string TryToGuessUnkownWords { get; set; }
            public string AutoBreakSubtitleIfMoreThanTwoLines { get; set; }
            public string AllFixes { get; set; }
            public string GuessesUsed { get; set; }
            public string UnknownWords { get; set; }
            public string OcrAutoCorrectionSpellchecking { get; set; }
            public string FixOcrErrors { get; set; }
            public string ImportTextWithMatchingTimeCodes { get; set; }
            public string SaveSubtitleImageAs { get; set; }
            public string SaveAllSubtitleImagesAsBdnXml { get; set; }
            public string SaveAllSubtitleImagesWithHtml { get; set; }
            public string XImagesSavedInY { get; set; }
            public string TryModiForUnknownWords { get; set; }
            public string DictionaryX  { get; set; }
            public string RightToLeft { get; set; }
            public string ShowOnlyForcedSubtitles { get; set; }
            public string UseTimeCodesFromIdx { get; set; }
            public string NoMatch { get; set; }
            public string AutoTransparentBackground { get; set; }
            public string SaveAllImagesWithHtmlIndex { get; set; }
            public string InspectCompareMatchesForCurrentImage { get; set; }
            public string EditLastAdditions { get; set; }
        }

        public class VobSubOcrCharacter
        {
            public string Title { get; set; }
            public string ShrinkSelection { get; set; }
            public string ExpandSelection { get; set; }
            public string SubtitleImage { get; set; }
            public string Characters { get; set; }
            public string CharactersAsText { get; set; }
            public string Italic { get; set; }
            public string Abort { get; set; }
            public string Skip { get; set; }
            public string Nordic { get; set; }
            public string Spanish { get; set; }
            public string German { get; set; }
            public string AutoSubmitOnFirstChar { get; set; }
            public string EditLastX { get; set; }
        }

        public class VobSubOcrCharacterInspect
        {
            public string Title { get; set; }
            public string InspectItems { get; set; }
            public string AddBetterMatch { get; set; }
        }

        public class VobSubOcrNewFolder
        {
            public string Title { get; set; }
            public string Message { get; set; }
        }

        public class WaveForm
        {
            public string ClickToAddWaveForm { get; set; }
            public string ClickToAddWaveformAndSpectrogram { get; set; }
            public string Seconds { get; set; }
            public string ZoomIn { get; set; }
            public string ZoomOut { get; set; }
            public string AddParagraphHere { get; set; }
            public string DeleteParagraph { get; set; }
            public string Split { get; set; }
            public string SplitAtCursor { get; set; }
            public string MergeWithPrevious { get; set; }
            public string MergeWithNext { get; set; }
            public string PlaySelection { get; set; }
            public string ShowWaveformAndSpectrogram { get; set; }
            public string ShowWaveformOnly { get; set; }
            public string ShowSpectrogramOnly { get; set; }
        }

    }
}
