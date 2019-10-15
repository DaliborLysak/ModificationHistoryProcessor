// 10.10.2018 [DaliborLysak] wrong last history line detection #3

using System;
using System.ComponentModel;

namespace ModificationHistoryProcessor
{
    public class ModificationHistorySettings
    {
        [Category("Replace Settings"), DefaultValue(@"(\[.*\])\s*(.*)"), Description("First regex group is ID, second is text, Ex. for default: [ID]  TEXT")]
        public string InputPattern { get; set; } = String.Empty;

        private bool ShouldSerializeInputPattern()
        {
            return String.IsNullOrEmpty(InputPattern);
        }

        [Category("Replace Settings"), DefaultValue(@"// DATE  NAME  ID TEXT")]
        public string OutputPattern { get; set; } = String.Empty;

        private bool ShouldSerializeOutputPattern()
        {
            return String.IsNullOrEmpty(OutputPattern);
        }
        
        [Category("Replace Settings"), DefaultValue("dlysak")]
        public string Name { get; set; } = String.Empty;

        private bool ShouldSerializeName()
        {
            return String.IsNullOrEmpty(Name);
        }

        [Category("Replace Settings"), DefaultValue("dd.MM.yyyy")]
        public string DateFormat { get; set; } = String.Empty;

        private bool ShouldSerializeDateFormat()
        {
            return String.IsNullOrEmpty(DateFormat);
        }

        [Category("Replace Settings"), DefaultValue(@"//.*\[{0,1}.*\]{0,1}\s*.*")]
        public string SearchPatternStart { get; set; } = String.Empty;

        private bool ShouldSerializeSearchPattern()
        {
            return String.IsNullOrEmpty(SearchPatternStart);
        }

        [Category("Replace Settings"), DefaultValue("namespace.*")]
        public string SearchPatternEnd { get; set; } = String.Empty;

        private bool ShouldSerializeSearchPatternEnd()
        {
            return String.IsNullOrEmpty(SearchPatternEnd);
        }

        [Category("Replace Settings"), DefaultValue("// MODIFICATION HISTORY")]
        public string HeaderSearchPattern { get; set; } = String.Empty;

        private bool ShouldSerializeHeaderSearchPattern()
        {
            return String.IsNullOrEmpty(HeaderSearchPattern);
        }

        [Category("Replace Settings"), DefaultValue(@"// MODIFICATION HISTORY\r\n// -----------------------------------------------------------------------------\r\n")]
        public string HeaderInplacePattern { get; set; } = String.Empty;

        private bool ShouldSerializeHeaderInplacePattern()
        {
            return String.IsNullOrEmpty(HeaderInplacePattern);
        }

        [Category("Input Settings"), DefaultValue(true)]
        public bool PreferClipboard { get; set; } = true;

        private bool ShouldSerializePreferClipboard()
        {
            return !PreferClipboard;
        }
    }
}
